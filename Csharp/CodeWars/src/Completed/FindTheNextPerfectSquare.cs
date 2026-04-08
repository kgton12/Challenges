namespace CodeWars.Completed;

public class FindTheNextPerfectSquare
{
    public static long FindNextSquare(long num)
    {
        double squareRoot = Math.Sqrt(num);
        if (squareRoot % 1 != 0)
            return -1;

        long root = (long)squareRoot;
        if (root * root != num)
            return -1;

        long next = root + 1;
        return next * next;
    }
}
