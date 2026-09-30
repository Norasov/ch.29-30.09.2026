namespace Domain.Models;

public static class Cache<T>
{
    private static List<T> values = [];
    public static void Add(T value)
    {
        values.Add(value);
    }
    public static List<T> Get()
    {
        return values;
    }
    public static void Remove(T value)
    {
        values.Remove(value);
    }
}
