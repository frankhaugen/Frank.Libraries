namespace Frank.Libraries.ML.CharacterRecognition;

public class Neuron
{
    private static readonly Random s_random = new();
    private readonly int _layer;
    private readonly NeuralNet _net;
    public readonly int Index;
    public double Bias;

    public double[] InputWeights;

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

    public Activator Activator => _net.Activators[_layer];

    public bool IsOutputNeuron => _layer == _net.Neurons.Length - 1;

    private static double GetSmallRandomNumber() =>
        (.0009 * s_random.NextDouble() + .0001)
        * (s_random.Next(2) == 0
            ? -1
            : 1);
}