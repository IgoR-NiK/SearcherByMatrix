namespace SearcherByMatrix.Extensions;

public static class DictionaryExtensions
{
    public static TValue AddOrUpdate<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue addValue,
        Func<TValue, TValue> updateValueFactory)
    {
        return dictionary[key] = dictionary.TryGetValue(key, out var existValue) 
            ? updateValueFactory(existValue) 
            : addValue;
    }
}