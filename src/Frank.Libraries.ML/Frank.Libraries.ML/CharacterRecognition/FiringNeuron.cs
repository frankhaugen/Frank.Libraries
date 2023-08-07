namespace Frank.Libraries.ML.CharacterRecognition;

public class FiringNeuron
{
    public readonly Neuron Neuron;
    public double InputVotes, OutputVotes; // Votes for change = slope of the loss vs input/output

    public double TotalInput, Output;

    public FiringNeuron(Neuron neuron) => Neuron = neuron;

    public void ComputeTotalInput(double[] inputValues)
    {
        double sum = 0;

        for (var i = 0; i < Neuron.InputWeights.Length; i++)
        {
            sum += inputValues[i] * Neuron.InputWeights[i];
        }

        TotalInput = Neuron.Bias + sum;
    }

    public unsafe void AdjustWeightsAndBias(double[] inputValues, double learningRate)
    {
        var adjustment = InputVotes * learningRate;

        lock (Neuron)
        {
            Neuron.Bias += adjustment;
        }

        var max = Neuron.InputWeights.Length;

        fixed (double* inputs = inputValues)
        fixed (double* weights = Neuron.InputWeights)
        {
            lock (Neuron.InputWeights)
            {
                for (var i = 0; i < max; i++)
                    // Neuron.InputWeights [i] += adjustment * inputValues [i];
                    // Using pointers avoids bounds-checking and so reduces the time spent holding the lock.
                {
                    *(weights + i) += adjustment * *(inputs + i);
                }
            }
        }
    }
}