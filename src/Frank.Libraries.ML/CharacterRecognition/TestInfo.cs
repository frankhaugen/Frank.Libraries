using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace Frank.Libraries.ML.CharacterRecognition;

public class TestInfo
{
    private const int ImageWidthHeight = 28;

    private readonly Lazy<Image> _image;
    public readonly ImageSample ImageSample;
    public readonly double[] OutputValues;

    public TestInfo(ImageSample imageSample, double[] outputValues)
    {
        ImageSample = imageSample;
        OutputValues = outputValues;
        _image = new Lazy<Image>(() => ToImage(ImageSample.Pixels, 0, ImageWidthHeight, ImageWidthHeight));
    }

    public bool IsCorrect => ImageSample.IsOutputCorrect(OutputValues);

    public double TotalLoss => OutputValues
                               .Select((v, i) => (v
                                                  - (i == ImageSample.Label
                                                      ? 1
                                                      : 0))
                                                 * (v
                                                    - (i == ImageSample.Label
                                                        ? 1
                                                        : 0))
                                                 / 2)
                               .Sum();

    public Image Image => _image.Value;

    private static unsafe Image ToImage(byte[] input, int offset, int width, int height)
    {
        fixed (byte* b = input)
        {
            var start = b + offset;
            var ptr = new IntPtr(start);
            var bmp = new Bitmap(width, height, width, PixelFormat.Format8bppIndexed, ptr);
            var pal = bmp.Palette;
            for (var i = 0; i < 256; i++)
            {
                pal.Entries[i] = Color.FromArgb(255, i, i, i);
            }

            bmp.Palette = pal;
            return new Bitmap(bmp, width * 3, height * 3);
        }
    }
}