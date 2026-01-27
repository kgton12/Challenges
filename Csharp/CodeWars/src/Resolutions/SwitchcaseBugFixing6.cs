namespace CodeWars.Resolutions;

public class SwitchcaseBugFixing6
{
    public static double EvalObject(double value1, double value2, char operation)
    {
        return operation switch
        {
            '+' => value1 + value2,
            '-' => value1 - value2,
            '/' => value1 / value2,
            '*' => value1 * value2,
            '%' => value1 % value2,
            '^' => Math.Pow(value1, value2),
            _ => 0
        };
    }
}
