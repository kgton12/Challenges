namespace CodeWars.Completed;

public class ShortestStepsToANumber
{
    public static int ShortestStepsToNum(int num)
    {
        int steps = 0;

        while (num > 1)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num--;

            steps++;
        }

        return steps;
    }
}