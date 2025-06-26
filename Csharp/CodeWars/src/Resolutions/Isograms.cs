namespace CodeWars.src.Resolutions;

public class Isograms
{
    public static bool IsIsogram(string str) => str.ToLower().Distinct().Count() == str.Length;
}
