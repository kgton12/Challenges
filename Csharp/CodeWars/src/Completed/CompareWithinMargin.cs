namespace CodeWars.Completed;

public class CompareWithinMargin
{
    public static int CloseCompare(double a, double b, double margin = 0)
    {
        if (Math.Abs(a - b) <= margin) return 0;
        else if (a < b) return -1;
        else if (a > b) return 1;

        return 0;
    }
}
