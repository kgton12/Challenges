namespace CodeWars.Completed;

public class AllInclusive
{
    public static bool ContainAllRots(string strng, List<string> arr)
    {
        if (string.IsNullOrEmpty(strng))
            return true;

        for (int i = 0; i < strng.Length; i++)
        {
            string rotation = string.Concat(strng.AsSpan(i), strng.AsSpan(0, i));
            if (!arr.Contains(rotation))
                return false;
        }
        return true;
    }
}
