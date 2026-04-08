namespace CodeWars.Completed;

public class IsThisATriangle
{
    public static bool IsTriangle(int a, int b, int c) =>
         a + b > c && a + c > b && b + c > a;
}
