namespace CodeWars.Completed;

public class BasicCalculator
{
    public static double Execute(double num1, char op, double num2)
    {
        return op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : throw new ArgumentException(),
            _ => throw new ArgumentException()
        };
    }
}
