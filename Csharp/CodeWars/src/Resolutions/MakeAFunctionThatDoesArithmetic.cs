namespace CodeWars.Resolutions;

public class MakeAFunctionThatDoesArithmetic
{
    public static double Arithmetic(double a, double b, string op)
    {
        return op switch
        {
            "add" => a + b,
            "subtract" => a - b,
            "multiply" => a * b,
            "divide" => a / b,
            _ => throw new ArgumentException(""),
        };
    }
}

