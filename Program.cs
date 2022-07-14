using BenchmarkDotNet.Running;
using BenchmarkTemplate.Benchmarks;

namespace BenchmarkTemplate;

public class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<MyAwesomeBenchmark>();

        Console.ReadKey();
    }
}