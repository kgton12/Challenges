namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1008
{
    public static void Salary()
    {
        int employeeId = Convert.ToInt32(Console.ReadLine());
        int hoursWorked = Convert.ToInt32(Console.ReadLine());
        double hourlyRate = Convert.ToDouble(Console.ReadLine());

        double salary = hourlyRate * hoursWorked;

        Console.WriteLine($"NUMBER = {employeeId}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");
    }
}
