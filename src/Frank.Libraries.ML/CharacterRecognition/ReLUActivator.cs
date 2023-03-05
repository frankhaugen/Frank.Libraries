namespace Frank.Libraries.ML.CharacterRecognition;

internal class ReLuActivator : Activator
{
    public override void ComputeOutputs(FiringNeuron[] layer)
    {
        foreach (var neuron in layer)
        {
            neuron.Output = neuron.TotalInput > 0
                ? neuron.TotalInput
                : neuron.TotalInput / 100;
        }
    }

    public override double GetActivationSlopeAt(FiringNeuron neuron) => neuron.TotalInput > 0
        ? 1
        : .01;
}