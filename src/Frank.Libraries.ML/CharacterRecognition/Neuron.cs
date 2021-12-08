using System;
using System.Linq;

namespace Frank.Libraries.ML.CharacterRecognition;

public class Neuron
{
    private readonly NeuralNet _net;
    private readonly int _layer;
    public readonly int Index;

    public double[] InputWeights;
    public double Bias;

    public Activator Activator => _net.Activators[_layer];

    public bool IsOutputNeuron => _layer == _net.Neurons.Length - 1;

    private static readonly Random s_random = new Random();

    private static double GetSmallRandomNumber() =>
        (.0009 * s_random.NextDouble() + .0001)
        * (s_random.Next(2) == 0
            ? -1
            : 1);

    public Neuron(NeuralNet net, int layer, int index, int inputWeightCount)
    {
        _net = net;
        _layer = layer;
        Index = index;

        Bias = GetSmallRandomNumber();
        InputWeights = Enumerable.Range(0, inputWeightCount)
                                 .Select(_ => GetSmallRandomNumber())
                                 .ToArray();
    }
}