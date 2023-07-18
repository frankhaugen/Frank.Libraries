using BenchmarkDotNet.Attributes;
using Frank.Libraries.Gaming.Core.Assets;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Tests.Benchmark.Gaming.Primitives;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[DisassemblyDiagnoser]
public class FaceFactoryBenchmark
{
    private readonly Polygon _polygon = PolygonAssetProvider.GetTeapot();

    [Benchmark]
    public void Parallel()
    {
        var result = FaceFactory.CreateParallel(_polygon);
    }

    [Benchmark]
    public void Normal()
    {
        var result = FaceFactory.CreateNormal(_polygon);
    }
}