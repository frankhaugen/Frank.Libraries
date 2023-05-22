namespace Frank.Libraries.ML.CharacterRecognition;

internal class HyperTanActivator : Activator
{
    public override void ComputeOutputs(FiringNeuron[] layer)
    {
        foreach (var neuron in layer)
        {
            neuron.Output = Math.Tanh(neuron.TotalInput);
        }
    }

    public override double GetActivationSlopeAt(FiringNeuron neuron)
    {
        var tanh = neuron.Output;
        return 1 - tanh * tanh;
    }
}