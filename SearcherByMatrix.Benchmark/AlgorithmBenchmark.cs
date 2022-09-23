using BenchmarkDotNet.Attributes;
using SearcherByMatrix;

namespace SearcherByMatrixBenchmark;

[MemoryDiagnoser]
public class AlgorithmBenchmark
{
    [ParamsSource(nameof(Source))]
    public Parameter Parameter { get; set; }
    
    [Benchmark(Baseline = true)]
    public void DictionaryAlgorithm()
    {
        var algorithm = new DictionaryAlgorithm();

        algorithm.Calculate(Parameter.N, Parameter.M, Parameter.Matrix);
    }
        
    [Benchmark]
    public void FindAllAlgorithm()
    {
        var algorithm = new FindAllAlgorithm();
        
        algorithm.Calculate(Parameter.N, Parameter.M, Parameter.Matrix);
    }

    public IEnumerable<Parameter> Source => new[]
    {
        new Parameter(1, 1, 1),
        new Parameter(10, 10, 15),
        new Parameter(100, 100, 1500),
        new Parameter(1_000, 1_000, 1500),
        //new Parameter(10_000, 10_000, 15_000_000),
        //new Parameter(100_000, 100_000, 1_500_000_000)
    };
}