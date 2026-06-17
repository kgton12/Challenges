namespace CodeWars.Completed;

public class FizzBuzzSolution
{
    public static int[] Solution(int number)
    {
        int a = 0;
        int b = 0;
        int c = 0;

        for (int i = 1; i < number; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
                a++;

            if (i % 3 != 0 && i % 5 == 0)
                b++;

            if (i % 3 == 0 && i % 5 == 0)
                c++;
        }

        return [a, b, c];
    }
}