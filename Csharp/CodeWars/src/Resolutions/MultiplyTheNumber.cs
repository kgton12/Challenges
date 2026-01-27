namespace CodeWars.Resolutions;

public class MultiplyTheNumber
{
    public static int Multiply(int number) => (int)(number * Math.Pow(5, Math.Abs(number).ToString().Length));
}
