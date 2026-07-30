namespace CodeWars.Completed;

public class HammingDistance
{
    public static int Distance(string a, string b) =>
        Enumerable.Range(0, a.Length).Count(v => a[v] != b[v]);
}