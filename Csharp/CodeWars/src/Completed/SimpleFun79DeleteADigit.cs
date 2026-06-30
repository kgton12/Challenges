namespace CodeWars.Completed;

public class SimpleFun79DeleteADigit
{
    public static int DeleteDigit(int n) =>
        n.ToString()
         .Select((_, i) => n.ToString().Remove(i, 1))
         .Max(Convert.ToInt32);
}