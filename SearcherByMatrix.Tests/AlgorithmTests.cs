namespace SearcherByMatrix.Tests;

using NUnit.Framework;

[TestFixture]
public class DictionaryAlgorithmTests
{
    [TestCaseSource(typeof(Sources))]
    public void DictionaryAlgorithmTest(int n, int m, string[][] matrix, int expected)
    {
        var algorithm = new DictionaryAlgorithm();

        var actual = algorithm.Calculate(n, m, matrix);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [TestCaseSource(typeof(Sources))]
    public void FindAllAlgorithmTest(int n, int m, string[][] matrix, int expected)
    {
        var algorithm = new FindAllAlgorithm();

        var actual = algorithm.Calculate(n, m, matrix);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}