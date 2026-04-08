namespace CodeWars.Completed;

public class SimpleCalculator
{
    public static double Calculator(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => throw new ArgumentException(""),
        };
    }
}

