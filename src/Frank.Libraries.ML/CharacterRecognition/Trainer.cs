namespace Frank.Libraries.ML.CharacterRecognition;

public class Trainer
{
    public readonly NeuralNet Net;

    // We want to cancel any outstanding training when the user cancels or re-runs the query.
    private readonly CancellationTokenSource _cancelSource = new();
    private Random _random = new();
    public double CurrentAccuracy;
    public int CurrentEpoch;
    public int Iterations;
    public string TrainingInfo;

    public Trainer(NeuralNet net) => Net = net;

    private ParallelOptions CancellableParallel => new() { CancellationToken = _cancelSource.Token };

    public void Train(Sample[] trainingData, Sample[] testingData, double learningRate, int epochs)
    {
        _random = new Random();
        var trainingSet = trainingData.ToArray();

        TrainingInfo = $"Learning rate = {learningRate}";

        for (CurrentEpoch = 0; CurrentEpoch < epochs; CurrentEpoch++)
        {
            Console.Write($"Training epoch {CurrentEpoch}... ");
            CurrentAccuracy = TrainEpoch(trainingSet, learningRate);
            learningRate *= .9; // This help to avoids oscillation as our accuracy improves.
            Console.WriteLine("Done. Training accuracy = " + CurrentAccuracy.ToString("N1") + "%");
        }

        var testAccuracy = ((Test(new FiringNet(Net), testingData) * 100).ToString("N1") + "%").Dump("% success with testing data");
        TrainingInfo += $"\r\nTotal epochs = {CurrentEpoch}\r\nFinal test accuracy = {testAccuracy}";
    }

    public double TrainEpoch(Sample[] trainingData, double learningRate)
    {
        Shuffle(_random, trainingData); // For each training epoch, randomize order of the training samples.

        // One FiringNet per thread to avoid thread-safety problems.
        var trainer = new ThreadLocal<FiringNet>(() => new FiringNet(Net));
        Parallel.ForEach(trainingData, CancellableParallel, sample =>
        {
            trainer.Value.Learn(sample.Data, sample.ExpectedOutput, learningRate);
            Interlocked.Increment(ref Iterations);
        });

        return Test(new FiringNet(Net), trainingData.Take(10000)
                                                    .ToArray())
               * 100;
    }

    public double Test(FiringNet firingNet, Sample[] samples)
    {
        int bad = 0, good = 0;
        foreach (var sample in samples)
        {
            firingNet.FeedForward(sample.Data);
            if (sample.IsOutputCorrect(firingNet.OutputValues.ToArray()))
            {
                good++;
            }
            else
            {
                bad++;
            }
        }

        return (double)good / (good + bad);
    }

    private static void Shuffle<T>(Random random, T[] array)
    {
        var n = array.Length;
        while (n > 1)
        {
            var k = random.Next(n--);
            var temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
    // Trainer() => Util.Cleanup += (sender, args) => _cancelSource.Cancel();

    // object ToDump() => NeuralNetRenderer(this);
}