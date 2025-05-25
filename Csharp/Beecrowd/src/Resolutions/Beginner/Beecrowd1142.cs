namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1142
{
    public static void PUM()
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int currentNumber = 1;
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine($"{currentNumber} {currentNumber + 1} {currentNumber + 2} PUM");
            currentNumber += 4;
        }
    }
}
