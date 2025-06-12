namespace BeeCrowd.src.Resolutions;

public class Beecrowd1943
{
    public static void TopN()
    {
        int[] topRanks = new int[] { 1, 3, 5, 10, 25, 50, 100 };

        int N = Convert.ToInt32(Console.ReadLine());

        foreach (var item in topRanks)
        {
            if (N <= item)
            {
                Console.WriteLine($"Top {item}");
                break;
            }
        }
    }
}
