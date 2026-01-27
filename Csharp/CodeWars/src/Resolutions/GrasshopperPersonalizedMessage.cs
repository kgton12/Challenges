namespace CodeWars.Resolutions;

public class GrasshopperPersonalizedMessage
{
    public static string Greet(string name, string owner) =>
         name.Equals(owner) ? "Hello boss" : "Hello guest";
}
