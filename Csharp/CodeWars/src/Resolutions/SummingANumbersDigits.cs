namespace CodeWars.Resolutions;

public class SummingANumbersDigits
{
    public static int SumDigits(int number) =>
        (int)Math.Abs(number).ToString().Sum(char.GetNumericValue);
}
