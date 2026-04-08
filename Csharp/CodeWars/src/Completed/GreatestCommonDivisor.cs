namespace CodeWars.Completed;

public class GreatestCommonDivisor
{
    public static int Gcd(int a, int b) =>
        b == 0 ? a : Gcd(b, a % b);
}
