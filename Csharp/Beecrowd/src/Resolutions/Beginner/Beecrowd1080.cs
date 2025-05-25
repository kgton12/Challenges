namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1080
{
    public static void LargestAndPosition()
    {
        int greaterValue = 0;
        int position = 0;

        for (int i = 1; i <= 100; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > greaterValue)
            {
                greaterValue = n;
                position = i;
            }
        }

        Console.WriteLine(greaterValue);
        Console.WriteLine(position);
    }
}
