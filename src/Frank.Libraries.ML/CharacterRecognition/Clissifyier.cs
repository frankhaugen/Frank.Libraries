using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Frank.Libraries.ML.CharacterRecognition;

public class Clissifyier
{
    private const int ImageWidthHeight = 28;

// #LINQPad optimize+
    private Sample[] _trainingData, _testingData;


    private async Task Main()
    {
        _trainingData = ImageSample.LoadTrainingImages(); // 50,000 training images
        _testingData = ImageSample.LoadTestingImages();   // 10,000 testing images

        var net = new NeuralNet(ImageWidthHeight * ImageWidthHeight, 20, 10);

        var trainer = new Trainer(net).Dump();

        await Task.Run(() => trainer.Train(_trainingData, _testingData, .01, 10));

        var failures =
            from testInfo in GetImageTestInfo(new FiringNet(net), _testingData)
            where !testInfo.IsCorrect
            select new { testInfo.Image, testInfo.ImageSample.Label, testInfo.TotalLoss, testInfo.OutputValues };

        failures.OrderByDescending(f => f.TotalLoss)
                .Take(100)
                .Dump("Failures with highest loss");
    }


    private static Color GetColor(double value, double min, double max, byte alpha)
    {
        if (value < min)
        {
            value = min;
        }

        if (value > max)
        {
            value = max;
        }

        var scaledValue = value < 0
            ? value / min
            : value / max;
        const byte greyPoint = 200;

        var colorChannel = Convert.ToByte(greyPoint + scaledValue * (255 - greyPoint));
        var secondChannel = Convert.ToByte(greyPoint - scaledValue * greyPoint * 8 / 10);
        var thirdChannel = Convert.ToByte(greyPoint - scaledValue * greyPoint * 9 / 10);

        return value < 0
            ? Color.FromArgb(alpha, thirdChannel, secondChannel, colorChannel)
            : Color.FromArgb(alpha, colorChannel, secondChannel, thirdChannel);
    }


    private static byte[] BitmapToByteArray(Bitmap bitmap)
    {
        BitmapData bmpdata = null;
        try
        {
            bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            var numbytes = bmpdata.Stride * bitmap.Height;
            var bytedata = new byte [numbytes];
            var ptr = bmpdata.Scan0;
            Marshal.Copy(ptr, bytedata, 0, numbytes);
            return bytedata;
        }
        finally
        {
            if (bmpdata != null)
            {
                bitmap.UnlockBits(bmpdata);
            }
        }
    }

    private static byte[] CentreImage(byte[] image, int stride)
    {
        var indexed = image.Select((value, i) => new { Column = i % stride, Row = i / stride, Value = value })
                           .ToArray();
        var orderedX = indexed.Where(x => x.Value > 10)
                              .OrderBy(x => x.Column)
                              .ToArray();
        if (!orderedX.Any())
        {
            return image;
        }

        var leftMargin = orderedX.First()
                                 .Column;
        var rightMargin = stride
                          - orderedX.Last()
                                    .Column;
        var orderedY = indexed.Where(x => x.Value > 10)
                              .OrderBy(x => x.Row)
                              .ToArray();
        var topMargin = orderedY.First()
                                .Row;
        var bottomMargin = stride
                           - orderedY.Last()
                                     .Row;
        var adjustmentRight = (rightMargin - leftMargin) / 2;
        var adjustmentDown = (bottomMargin - topMargin) / 2;
        var newImage = new byte [image.Length];
        for (var i = 0; i < stride; i++)
        for (var j = 0; j < stride; j++)
        {
            if (i < adjustmentDown || i >= stride + adjustmentDown || j < adjustmentRight || j >= stride + adjustmentRight)
            {
                newImage[i * stride + j] = 0;
            }
            else
            {
                newImage[i * stride + j] = image[(i - adjustmentDown) * stride + j - adjustmentRight];
            }
        }

        return newImage;
    }

    private static IEnumerable<TestInfo> GetImageTestInfo(FiringNet firingNet, Sample[] samples)
    {
        foreach (ImageSample sample in samples)
        {
            firingNet.FeedForward(sample.Data);
            yield return new TestInfo(sample, firingNet.OutputValues.ToArray());
        }
    }
}