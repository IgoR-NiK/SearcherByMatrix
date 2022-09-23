namespace SearcherByMatrix.Extensions;

public static class EnumerableExtensions
{
    public static int Max(this IEnumerable<int> items)
    {
        var result = int.MinValue;

        foreach (var item in items)
        {
            if (item > result)
            {
                result = item;
            }
        }

        return result;
    }
}