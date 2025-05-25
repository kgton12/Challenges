namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1072
{
    public static void Interval2()
    {
        int numberOfInputs = Convert.ToInt32(Console.ReadLine());
        int countIn = 0;
        int countOut = 0;

        for (int i = 0; i < numberOfInputs; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value >= 10 && value <= 20) countIn++;
            else countOut++;
        }

        Console.WriteLine($"{countIn} in");
        Console.WriteLine($"{countOut} out");
    }
}
