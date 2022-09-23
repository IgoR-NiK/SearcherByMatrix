namespace SearcherByMatrix;

using Extensions;

public class DictionaryAlgorithm : IAlgorithm
{
    public int Calculate(int n, int m, string[][] matrix)
    {
        var dictionary = new Dictionary<(int, string), int>();

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                dictionary.AddOrUpdate((i, matrix[i][j]), 1, v => v + 1);
                dictionary.AddOrUpdate((n + j, matrix[i][j]), 1, v => v + 1);
            }
        }
			
        return dictionary.Values.Max();
    }
}