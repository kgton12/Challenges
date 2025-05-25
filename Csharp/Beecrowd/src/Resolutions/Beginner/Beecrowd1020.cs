namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1020
{
    public static void AgeinDays()
    {
        int days = Convert.ToInt32(Console.ReadLine());

        int year = (int)(days / 365);
        days -= (year * 365);

        int month = (int)(days / 30);
        days -= (month * 30);

        Console.WriteLine($"{year} ano(s)");
        Console.WriteLine($"{month} mes(es)");
        Console.WriteLine($"{days} dia(s)");
    }
}
