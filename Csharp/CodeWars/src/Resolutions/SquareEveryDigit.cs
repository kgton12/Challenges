namespace CodeWars.Resolutions;

public class SquareEveryDigit
{
    public static int SquareDigits(int n) =>
        int.Parse(string.Concat(n.ToString().Select(c => Math.Pow(char.GetNumericValue(c), 2).ToString()
        )));
}
