using System;

namespace Frank.Libraries.ML.CharacterRecognition;

public class SoftMaxActivator : Activator
{
    public override void ComputeOutputs(FiringNeuron[] layer)
    {
        double sum = 0;

        foreach (var neuron in layer)
        {
            neuron.Output = Math.Exp(neuron.TotalInput);
            sum += neuron.Output;
        }

        foreach (var neuron in layer)
        {
            neuron.Output /= sum == 0 ? 1 : sum;
        }
    }

    public override double GetActivationSlopeAt(FiringNeuron neuron)
    {
        var y = neuron.Output;
        return y * (1 - y);
    }
}