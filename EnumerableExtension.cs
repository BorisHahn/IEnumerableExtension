namespace IEnumerableExtension;

public static class EnumerableExtension
{
    public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percent)
    {
        if (percent < 1 || percent > 100)
        {
            throw new ArgumentException("Заданный параметр выходит за допустимый диапазон");
        }

        float collectionLength = source.Count();
        int totalCount = (int)Math.Ceiling((collectionLength * percent) / 100);
        var result = source.TakeLast(totalCount);
        return result;
    }

    public static IEnumerable<T> Top<T>(
        this IEnumerable<T> source, int percent, Func<T, int> selector) =>
        source.Top(percent).OrderByDescending(selector);
}