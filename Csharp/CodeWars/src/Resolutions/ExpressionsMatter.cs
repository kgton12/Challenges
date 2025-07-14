namespace CodeWars.src.Resolutions;

public class ExpressionsMatterClass
{
    public static int ExpressionsMatter(int a, int b, int c) =>
        new[] { a + b + c, a * b * c, (a + b) * c, a * (b + c), a + b * c, a * b + c }.Max();
}
