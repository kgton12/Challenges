namespace CodeWars.src.Resolutions;

public class SuperDuperEasy
{
    public static string Problem(String a)
    {
        if (double.TryParse(a, out double value))
            return (value * 50 + 6).ToString();

        return "Error";
    }
}
