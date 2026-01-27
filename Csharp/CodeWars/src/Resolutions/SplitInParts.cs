namespace CodeWars.Resolutions;

public class SplitInPartsClass
{
    public static string SplitInParts(string s, int partLength)
    {
        List<string> result = [];
        int parts = (int)Math.Ceiling((double)s.Length / partLength);

        Enumerable.Range(0, parts).ToList().ForEach(index =>
        {
            int start = index * partLength;
            int length = Math.Min(partLength, s.Length - start);
            result.Add(s.Substring(start, length));
        });

        return string.Join(" ", result);
    }
}
