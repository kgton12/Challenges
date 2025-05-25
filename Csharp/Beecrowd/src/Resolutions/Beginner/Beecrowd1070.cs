namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1070
{
    public static void SixOddNumbers()
    {
        int startNumber = Convert.ToInt32(Console.ReadLine());

        int firstOdd = (startNumber % 2 != 0) ? startNumber : startNumber + 1;

        for (int count = 0; count < 6; count++)
        {
            Console.WriteLine(firstOdd + count * 2);
        }
    }
}
