namespace CodeWars.Completed;

public class HeadsAndLegs
{
    public static object Animals(int heads, int legs)
    {
        if (heads == 0 && legs == 0) return new int[] { 0, 0 };

        if (heads < 0 || legs < 0) return "No solutions";

        if (legs % 2 != 0) return "No solutions";

        int cowsNumerator = legs - 2 * heads;
        if (cowsNumerator < 0) return "No solutions";

        if (cowsNumerator % 2 != 0) return "No solutions";
        int cows = cowsNumerator / 2;
        int chickens = heads - cows;

        if (cows < 0 || chickens < 0) return "No solutions";

        return new int[] { chickens, cows };
    }
}
