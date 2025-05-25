namespace CodeWars.src;

public class SuperDuperEasy
{
    public static string Problem(String a)
    {

        if (double.TryParse(a, out double value))
            return (value * 50 + 6).ToString();


        //magic code 
        return string.Empty;
    }
}
