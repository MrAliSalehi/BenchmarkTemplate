
using BenchmarkDotNet.Attributes;

namespace BenchmarkTemplate.Benchmarks;

// pass false if you don't want to see Gen column's
[MemoryDiagnoser]
public class MyAwesomeBenchmark
{
    [Benchmark]
    public void MyMethod()
    {

    }

    [Benchmark]
    public bool MyCuteMethod()
    {
        return true;
    }
}