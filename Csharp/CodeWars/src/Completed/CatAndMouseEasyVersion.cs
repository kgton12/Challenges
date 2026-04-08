namespace CodeWars.Completed;

public class CatAndMouseEasyVersion
{
    public static string CatMouse(string x) => x.Count(x => x == '.') <= 3 ? "Caught!" : "Escaped!";
}
