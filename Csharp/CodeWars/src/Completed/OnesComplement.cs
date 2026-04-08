namespace CodeWars.Completed;

public class OnesComplementClass
{
    public static string OnesComplement(string n) =>
        string.Concat(n.Select(x => x == '0' ? '1' : '0'));
}
