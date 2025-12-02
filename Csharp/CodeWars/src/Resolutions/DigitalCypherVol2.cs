namespace CodeWars.src.Resolutions;

public class DigitalCypherVol2
{
    public static string Decode(int[] code, int key)
    {
        List<char> result = [];
        var loopArray = MakeLoopArray(key, code.Length).Select(char.GetNumericValue).ToArray();

        for (int i = 0; i < code.Length; i++)
        {
            result.Add(
                    GetIntegerValue(Convert.ToInt32(code[i] - Convert.ToInt32(loopArray[i])))
            );
        }

        return string.Concat(result);
    }

    private static char GetIntegerValue(int c) =>
         Convert.ToChar(c + 'a' - 1);

    private static string MakeLoopArray(int n, int length) =>
        string.Concat(Enumerable.Repeat(n.ToString(), (int)Math.Ceiling((decimal)length / n.ToString().Length)));
}