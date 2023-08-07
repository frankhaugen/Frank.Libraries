namespace Frank.Libraries.ML.CharacterRecognition;

public abstract class Activator
{
    public abstract void ComputeOutputs(FiringNeuron[] layer);
    public abstract double GetActivationSlopeAt(FiringNeuron neuron);
}