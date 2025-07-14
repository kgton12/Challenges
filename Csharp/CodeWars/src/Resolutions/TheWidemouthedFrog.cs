namespace CodeWars.src.Resolutions;

public class TheWidemouthedFrog
{
    public static string MouthSize(string animal) =>
        animal.Equals("alligator", StringComparison.CurrentCultureIgnoreCase) ? "small" : "wide";
}
