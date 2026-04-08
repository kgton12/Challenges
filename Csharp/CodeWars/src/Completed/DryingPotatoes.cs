namespace CodeWars.Completed;

public class DryingPotatoes
{
    public static int Potatoes(int p0, int w0, int p1)
    {
        var dryMatter = w0 * (100 - p0);

        return (int)Math.Floor((decimal)dryMatter / (100 - p1));
    }
}
