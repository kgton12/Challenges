namespace CodeWars.src.Resolutions;

public class SumTheStrings
{
    public static string StringsSum(string s1, string s2)
    {
        int.TryParse(s1, out int value1);
        int.TryParse(s2, out int value2);
        return Convert.ToString(value1 + value2);
    }
}
