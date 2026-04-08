namespace CodeWars.Completed;

public class FindNearestSquareNumber
{
    public static int NearestSq(int n)
    {
        double sqrt = Math.Sqrt(n);

        if (sqrt % 1 == 0)
            return n;

        int lower = (int)Math.Pow(Math.Floor(sqrt), 2);
        int upper = (int)Math.Pow(Math.Ceiling(sqrt), 2);

        return Math.Abs(n - lower) <= Math.Abs(n - upper) ? lower : upper;
    }
}
