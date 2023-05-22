namespace Frank.Libraries.ML.CharacterRecognition;

public class NeuralNet
{
    public readonly Neuron[][] Neurons; // Layers of neurons
    public Activator[] Activators;      // Activators for each layer

    public NeuralNet(params int[] neuronsInEachLayer) // including the input layer
    {
        Neurons = neuronsInEachLayer
                  .Skip(1) // Skip the input layer
                  .Select((count, layer) =>
                              Enumerable.Range(0, count)
                                        .Select(index => new Neuron(this, layer, index, neuronsInEachLayer[layer]))
                                        .ToArray())
                  .ToArray();

        // Default to ReLU activators
        Activators = Enumerable
                     .Repeat((Activator)new ReLuActivator(), neuronsInEachLayer.Length - 1)
                     .ToArray();
    }
}