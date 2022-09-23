namespace SearcherByMatrix;

public class FindAllAlgorithm : IAlgorithm
{
    public int Calculate(int n, int m, string[][] matrix)
    {
        var maxCount = Math.Max(n, m);
        var currentMaxCount = 0;

        var rowIndex = 0;
        var columnIndex = 0;
        var rowMaxCount = 0;
        var columnMaxCount = 0;

        for (var i = 0; i < maxCount; i++)
        {
            if (n > i)
            {
                var row = matrix[rowIndex];

                rowMaxCount = GetMaxCountOfSameElement(row);

                rowIndex++;
            }

            if (m > i)
            {
                var column = GetColumn(matrix, columnIndex);

                columnMaxCount = GetMaxCountOfSameElement(column);

                columnIndex++;
            }

            var localMaxCount = Math.Max(rowMaxCount, columnMaxCount);

            if (localMaxCount > currentMaxCount)
                currentMaxCount = localMaxCount;
        }

        return currentMaxCount;
    }

    private static int GetMaxCountOfSameElement(string[] input)
    {
        var maxCount = 0;

        for (var i = 0; i < input.Length; i++)
        {
            var count = Array.FindAll(input, it => it == input[i]).Length;

            if (count > maxCount)
                maxCount = count;
        }

        return maxCount;
    }

    private static string[] GetColumn(string[][] input, int column)
    {
        var rowLength = input.Length;
        var result = new string[rowLength];

        for (var i = 0; i < rowLength; i++)
        {
            var row = input[i];

            result[i] = row[column];
        }

        return result;
    }
}