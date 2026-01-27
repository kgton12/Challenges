namespace CodeWars.Resolutions;

public class DigitalCypher
{
    public static int[] Encode(string str, int n)
    {
        List<int> result = [];
        string loopArray = MakeLoopArray(n, str.Length);

        for (int i = 0; i < str.Length; i++)
        {
            result.Add(
                 GetIntegerValue(str[i]) + (int)char.GetNumericValue(loopArray[i])
                 );

        }

        return [.. result];
    }

    private static int GetIntegerValue(char c) =>
        c - 'a' + 1;

    private static string MakeLoopArray(int n, int length) =>
        string.Concat(Enumerable.Repeat(n.ToString(), (int)Math.Ceiling((decimal)length / n.ToString().Length)));
}
