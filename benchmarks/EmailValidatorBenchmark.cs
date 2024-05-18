using BenchmarkDotNet.Attributes;
using yt_benchmark.validators;

namespace yt_benchmark.benchmarks;

[MemoryDiagnoser]
public class EmailValidatorBenchmark
{
    static int NumberOfValidations = 100;

    [Benchmark(Baseline = true)]
    public void Regex()
    {
        var validator = new EmailValidatorRegex();
        for (int i = 0; i < NumberOfValidations; i++)
        {
            validator.IsValid("test@itamar.com");
        }
    }

    [Benchmark]
    public void RegexCompiled()
    {
        var validator = new EmailValidatorRegexCompiled();
        for (int i = 0; i < NumberOfValidations; i++)
        {
            validator.IsValid("test@itamar.com");
        }
    }    

    [Benchmark]
    public void Simple()
    {
        var validator = new EmailValidatorSimple();
        for (int i = 0; i < NumberOfValidations; i++)
        {
            validator.IsValid("test@itamar.com");
        }
    }
}
