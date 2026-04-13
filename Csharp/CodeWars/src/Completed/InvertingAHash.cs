namespace CodeWars.Completed;

public class InvertingAHash
{
    public static Dictionary<TValue, TKey> InvertHash<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        where TKey : notnull
        where TValue : notnull
    {
        return dictionary.ToDictionary(dic => dic.Value, dic => dic.Key);
    }
}