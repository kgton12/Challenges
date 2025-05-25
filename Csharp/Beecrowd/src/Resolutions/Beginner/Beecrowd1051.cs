namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1051
{
    public static void IncomeTax()
    {
        double income = Convert.ToDouble(Console.ReadLine() ?? string.Empty);

        if (income <= 2000.00f)
            Console.WriteLine("Isento");
        else if (income <= 3000.00f)
        {
            income -= 2000.00f;
            income *= 0.08;
            Console.WriteLine("R$ {0:F2}", income);
        }
        else if (income <= 4500.00f)
        {
            income -= 3000.00f;
            income *= 0.18;
            income += (1000 * 0.08);
            Console.WriteLine("R$ {0:F2}", income);
        }
        else
        {
            income -= 4500.00f;
            income *= 0.28;
            income += (1500 * 0.18) + (1000 * 0.08);
            Console.WriteLine("R$ {0:F2}", income);
        }
    }
}
