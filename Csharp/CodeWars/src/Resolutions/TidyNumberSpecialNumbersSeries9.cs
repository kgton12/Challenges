namespace CodeWars.src.Resolutions;

public class TidyNumberSpecialNumbersSeries9
{
    public static bool TidyNumber(int n) =>
        string.Concat(n.ToString().OrderBy(x => x)).Equals(n.ToString());
}
