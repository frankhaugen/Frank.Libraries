using System;
using System.Linq;

namespace Frank.Libraries.ML.CharacterRecognition;

public class TestInfo
{
    public readonly ImageSample ImageSample;
    public readonly double[] OutputValues;

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

    readonly Lazy<System.Drawing.Image> _image;
    public System.Drawing.Image Image => _image.Value;

    public TestInfo(ImageSample imageSample, double[] outputValues)
    {
        ImageSample = imageSample;
        OutputValues = outputValues;
        _image = new Lazy<System.Drawing.Image>(() => ToImage(ImageSample.Pixels, 0, ImageWidthHeight, ImageWidthHeight));
    }

    private const int ImageWidthHeight = 28;

    private static unsafe System.Drawing.Image ToImage(byte[] input, int offset, int width, int height)
    {
        fixed (byte* b = input)
        {
            var start = b + offset;
            var ptr = new IntPtr(start);
            var bmp = new System.Drawing.Bitmap(width, height, width, System.Drawing.Imaging.PixelFormat.Format8bppIndexed, ptr);
            System.Drawing.Imaging.ColorPalette pal = bmp.Palette;
            for (var i = 0; i < 256; i++) pal.Entries[i] = System.Drawing.Color.FromArgb(255, i, i, i);
            bmp.Palette = pal;
            return new System.Drawing.Bitmap(bmp, width * 3, height * 3);
        }
    }
}