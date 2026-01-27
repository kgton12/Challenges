namespace CodeWars.Resolutions;

public class StringReverseSlicing101
{
    public static string[] ReverseSlice(string str)
    {
        List<string> result = [];

        string reversedStr = string.Concat(str.Reverse());

        for (int i = 0; i < str.Length; i++)
            result.Add(reversedStr[i..str.Length]);

        return [.. result];
    }
}