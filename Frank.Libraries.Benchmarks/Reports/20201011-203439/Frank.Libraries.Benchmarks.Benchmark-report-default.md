
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
AMD FX-8370, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Toolchain=InProcessEmitToolchain  InvocationCount=1  UnrollFactor=1  

            Method |     Mean |   Error |   StdDev |
------------------ |---------:|--------:|---------:|
   PasswordHashing | 162.5 ms | 3.21 ms |  7.05 ms |
 LanguageDetection | 295.9 ms | 6.07 ms | 17.53 ms |
