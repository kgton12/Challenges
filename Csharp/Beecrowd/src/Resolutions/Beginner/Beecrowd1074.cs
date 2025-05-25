namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1074
{
    public static void OddOrEven()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            string isOddOrEven = value == 0 ? "NULL" : value % 2 == 0 ? "EVEN" : "ODD";
            string isPositiveOrNegative = value > 0 ? "POSITIVE" : "NEGATIVE";

            if (isOddOrEven == "NULL") Console.WriteLine(isOddOrEven);
            else Console.WriteLine($"{isOddOrEven} {isPositiveOrNegative}");
        }
    }
}
