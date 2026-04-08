namespace CodeWars.Completed;

public class EvilOrOdious
{
    public static string Evil(int n) => Convert.ToString(n, 2).Count(x => x == '1') % 2 == 0 ? "It's Evil!" : "It's Odious!";
}