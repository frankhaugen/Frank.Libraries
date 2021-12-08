namespace Frank.Libraries.ML.CharacterRecognition;

public class SoftMaxActivatorWithCrossEntropyLoss : SoftMaxActivator // Use this only on the output layer!
{
    // This is the derivative after modifying the loss function.
    public override double GetActivationSlopeAt(FiringNeuron neuron) => 1;
}