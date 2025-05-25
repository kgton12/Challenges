namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1048
{
    public static void SalaryIncrease()
    {
        double salary, salaryIncrease, newSalary;
        string[] inputLine = (Console.ReadLine() ?? string.Empty).Split(' ');

        salary = Convert.ToDouble(inputLine[0]);

        if (salary > 0 && salary <= 400)
        {//15%
            salaryIncrease = salary * 0.15;
            newSalary = salary + salaryIncrease;
            Console.WriteLine($"Novo salario: {newSalary:f2}");
            Console.WriteLine($"Reajuste ganho: {salaryIncrease:f2}");
            Console.WriteLine($"Em percentual: 15 %");
        }
        else if (salary >= 400.01 && salary <= 800)
        {//12%
            salaryIncrease = salary * 0.12;
            newSalary = salary + salaryIncrease;
            Console.WriteLine($"Novo salario: {newSalary:f2}");
            Console.WriteLine($"Reajuste ganho: {salaryIncrease:f2}");
            Console.WriteLine($"Em percentual: 12 %");
        }
        else if (salary >= 800.01 && salary <= 1200)
        {//10%
            salaryIncrease = salary * 0.10;
            newSalary = salary + salaryIncrease;
            Console.WriteLine($"Novo salario: {newSalary:f2}");
            Console.WriteLine($"Reajuste ganho: {salaryIncrease:f2}");
            Console.WriteLine($"Em percentual: 10 %");
        }
        else if (salary >= 1200.01 && salary <= 2000)
        {//7%
            salaryIncrease = salary * 0.07;
            newSalary = salary + salaryIncrease;
            Console.WriteLine($"Novo salario: {newSalary:f2}");
            Console.WriteLine($"Reajuste ganho: {salaryIncrease:f2}");
            Console.WriteLine($"Em percentual: 7 %");
        }
        else if (salary > 2000)
        {//4%
            salaryIncrease = salary * 0.04;
            newSalary = salary + salaryIncrease;
            Console.WriteLine($"Novo salario: {newSalary:f2}");
            Console.WriteLine($"Reajuste ganho: {salaryIncrease:f2}");
            Console.WriteLine($"Em percentual: 4 %");
        }
    }
}
