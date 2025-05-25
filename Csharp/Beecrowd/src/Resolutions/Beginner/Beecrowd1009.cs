namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1009
{
    public static void SalaryWithBonus()
    {
        string _ = Console.ReadLine() ?? string.Empty;
        double salary = Convert.ToDouble(Console.ReadLine());
        double sales = Convert.ToDouble(Console.ReadLine());

        double salaryWithCommission = salary + sales * 0.15;

        Console.WriteLine($"TOTAL = R$ {salaryWithCommission:F2}");
    }
}
