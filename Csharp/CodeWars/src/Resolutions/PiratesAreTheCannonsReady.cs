namespace CodeWars.Resolutions;

public class PiratesAreTheCannonsReady
{
    public static string CannonsReady(Dictionary<string, string> gunners) =>
        gunners.All(x => x.Value == "aye")
            ? "Fire!"
            : "Shiver me timbers!";
}
