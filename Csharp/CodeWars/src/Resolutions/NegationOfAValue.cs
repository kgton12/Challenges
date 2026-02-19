namespace CodeWars.Resolutions;

public class NegationOfAValue
{
    public static bool NegationValue(string str, bool value) =>
        (str.Length % 2 == 0) == value;
}
