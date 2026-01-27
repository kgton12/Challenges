namespace CodeWars.Resolutions;

public class CountTheDivisorsOfANumber
{
    public static int Divisors(int n) =>
        Enumerable.Range(1, n).Count(x => n % x == 0);
}