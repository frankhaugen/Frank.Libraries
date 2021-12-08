using System;

namespace Frank.Libraries.ML.CharacterRecognition;

class LogisticSigmoidActivator : Activator
{
    public override void ComputeOutputs(FiringNeuron[] layer)
    {
        foreach (var neuron in layer)
            neuron.Output = 1 / (1 + Math.Exp(-neuron.TotalInput));
    }

    public override double GetActivationSlopeAt(FiringNeuron neuron)
        => neuron.Output * (1 - neuron.Output);
}