namespace CodeWars.Resolutions;

public class BumpsInTheRoad
{
    public static string Bump(string input) =>
        input.Count(x => x == 'n') > 15 ? "Car Dead" : "Woohoo!";
}
