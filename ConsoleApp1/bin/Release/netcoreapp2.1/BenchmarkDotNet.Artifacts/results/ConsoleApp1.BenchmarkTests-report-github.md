``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.500
  [Host]     : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev |
|------- |---------:|----------:|----------:|
|  test1 | 500.7 ms | 0.3385 ms | 0.3167 ms |
|  test2 | 500.6 ms | 0.3601 ms | 0.3369 ms |
