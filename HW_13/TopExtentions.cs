using System.Runtime.InteropServices.ComTypes;

namespace HW_13;

public static class TopExtentions
{
    public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
    {
        if (percent < 0 || percent > 100)
            throw new ArgumentException();
        var enumerable = collection as T[] ?? collection.ToArray();
        var math = (double)enumerable.Length * percent / 100;
        var quantity = (int)Math.Ceiling(math);
        return enumerable.OrderByDescending(x => x).Take(quantity);
    }

    public static IEnumerable<int> Top<T>(this IEnumerable<T> collection, int percent, Func<T, int> predicate)
    {
        if (percent < 0 || percent > 100)
            throw new ArgumentException();
        var enumerable = collection.Select(predicate).ToArray();
        var math = (double)enumerable.Length * percent / 100;
        var quantity = (int)Math.Ceiling(math);
        return enumerable.OrderByDescending(x => x).Take(quantity);

    }
}