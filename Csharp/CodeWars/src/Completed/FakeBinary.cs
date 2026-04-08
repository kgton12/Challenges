namespace CodeWars.Completed;

public class FakeBinary
{
    public static string FakeBin(string x) =>
        string.Concat(x.Select(x => char.GetNumericValue(x) < 5 ? "0" : "1"));
}
