using System.Collections;

namespace SearcherByMatrix.Tests;

public class Sources : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return new object[] { 1, 1, new[]
        {
            new[] { "a" }
        }, 1 };
        
        yield return new object[] { 1, 7, new[]
        {
            new[] { "a", "a", "b", "c", "c", "c", "d" }
        }, 3 };
        
        yield return new object[] { 7, 1, new[]
        {
            new[] { "a" },
            new[] { "a" }, 
            new[] { "b" }, 
            new[] { "c" }, 
            new[] { "c" }, 
            new[] { "c" }, 
            new[] { "d" }
        }, 3 };
        
        yield return new object[] { 5, 7, new[]
        {
            new [] { "a", "a", "b", "c", "c", "c", "d" },
            new [] { "1", "2", "3", "4", "5", "6", "7" },
            new [] { "11", "22", "33", "44", "55", "66", "77" },
            new [] { "111", "222", "333", "444", "555", "666", "777" },
            new [] { "1111", "2222", "3333", "4444", "5555", "6666", "7777" }
        }, 3 };
    }
}