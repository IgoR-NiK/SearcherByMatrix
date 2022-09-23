namespace SearcherByMatrixBenchmark;

public class Parameter
{
    private readonly Random _random = new();
    
    public int N { get; }
    
    public int M { get; }
    
    public string[][] Matrix { get; }

    public Parameter(int n, int m, int uniqueStringCount)
    {
        N = n;
        M = m;
        Matrix = new string[n][];

        var uniqueStrings = GenerateUniqueStrings(uniqueStringCount);
        
        for (var i = 0; i < n; i++)
        {
            Matrix[i] = new string[m];

            for (var j = 0; j < m; j++)
            {
                Matrix[i][j] = uniqueStrings[_random.Next(uniqueStringCount)];
            }
        }
    }

    public override string ToString()
    {
        return $"Matrix[{N}][{M}]";
    }

    private List<string> GenerateUniqueStrings(int uniqueStringCount)
    {
        var hashSet = new HashSet<string>();

        while (hashSet.Count != uniqueStringCount)
        {
            hashSet.Add(new string(Enumerable.Range(0, 2 * uniqueStringCount / 25 + 1).Select(_ => (char)_random.Next('a', 'z')).ToArray()));
        }

        return hashSet.ToList();
    }
}