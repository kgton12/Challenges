namespace CodeWars.Resolutions;

public class WeHaveLiftoff
{
    public static string Liftoff(List<int> instructions) =>
        string.Join(" ", instructions.OrderByDescending(x => x)) + " liftoff!";
}
