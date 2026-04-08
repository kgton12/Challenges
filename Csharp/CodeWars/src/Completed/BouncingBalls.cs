namespace CodeWars.Completed;

public class BouncingBalls
{
    public static int BouncingBall(double h, double bounce, double window)
    {
        double heightValue = h;

        if (heightValue <= 0 || bounce <= 0 || bounce >= 1 || window >= heightValue)
            return -1;

        int totalPasses = 0;

        while (heightValue > window)
        {
            totalPasses++;

            if (heightValue * bounce > window)
                totalPasses++;

            heightValue *= bounce;
        }

        return totalPasses;
    }
}
