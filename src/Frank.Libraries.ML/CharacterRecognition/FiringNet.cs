using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.ML.CharacterRecognition;

public class FiringNet
{
    private readonly NeuralNet _net;
    private readonly FiringNeuron[][] _neurons;
    private readonly FiringNeuron[]?[] _neuronsWithLayersReversed;

    public FiringNet(NeuralNet net)
    {
        _net = net;
        _neurons = _net.Neurons.Select(layer => layer.Select(n => new FiringNeuron(n))
                                                     .ToArray())
                       .ToArray();
        _neuronsWithLayersReversed = _neurons.Reverse()
                                             .ToArray();
    }

    private FiringNeuron[] OutputLayer => _neurons[^1];

    public IEnumerable<double> OutputValues => OutputLayer.Select(n => n.Output);

    public void FeedForward(double[] inputValues)
    {
        var i = 0;
        foreach (var layer in _neurons)
        {
            foreach (var neuron in layer)
            {
                neuron.ComputeTotalInput(inputValues);
            }

            _net.Activators[i++]
                .ComputeOutputs(layer);

            // The outputs for this layer become the inputs for the next layer.
            if (layer != OutputLayer)
            {
                inputValues = layer.Select(l => l.Output)
                                   .ToArray();
            }
        }
    }

    public void Learn(double[] inputValues, double[] desiredOutputs, double learningRate)
    {
        FeedForward(inputValues);

        FiringNeuron[]? layerJustProcessed = null;

        // Calculate all the output and input votes.
        foreach (var layer in _neuronsWithLayersReversed)
        {
            var isOutputLayer = layerJustProcessed == null;
            if (layer == null)
            {
                continue;
            }

            foreach (var neuron in layer)
            {
                if (isOutputLayer)
                    // For neurons in the output layer, the loss vs output slope = -error.
                {
                    neuron.OutputVotes = desiredOutputs[neuron.Neuron.Index] - neuron.Output;
                }
                else
                    // For hidden neurons, the loss vs output slope = weighted sum of next layer's input slopes.
                if (layerJustProcessed != null)
                {
                    neuron.OutputVotes = layerJustProcessed.Sum(n => n.InputVotes * n.Neuron.InputWeights[neuron.Neuron.Index]);
                }

                // The loss vs input slope = loss vs output slope times activation function slope (chain rule).
                neuron.InputVotes = neuron.OutputVotes * neuron.Neuron.Activator.GetActivationSlopeAt(neuron);
            }

            layerJustProcessed = layer;
        }

        // We can improve the training by scaling the learning rate by the layer index.
        var learningRateMultiplier = _neurons.Length;

        // Updates weights and biases.
        foreach (var layer in _neurons)
        {
            foreach (var neuron in layer)
            {
                neuron.AdjustWeightsAndBias(inputValues, learningRate * learningRateMultiplier);
            }

            if (layer != OutputLayer)
            {
                inputValues = layer.Select(l => l.Output)
                                   .ToArray();
            }

            learningRateMultiplier--;
        }
    }
}