using System;

namespace Frank.Libraries.ML.CharacterRecognition;

public class Sample
{
    public double[] Data;
    public double[] ExpectedOutput;
    public Func<double[], bool> IsOutputCorrect;
}