namespace CodeWars.src.Resolutions;

public class TheVowelCode
{
    private static readonly string vowelForNumber = "aeiou";

    public static string Encode(string msg)
    {
        for (int i = 0; i < vowelForNumber.Length; i++)
            msg = msg.Replace(vowelForNumber[i].ToString(), (i + 1).ToString());

        return msg;
    }

    public static string Decode(string msg) =>
        string.Concat(msg.Select(x => char.IsDigit(x) ? vowelForNumber[(int)char.GetNumericValue(x) - 1] : x));
}
