namespace CodeWars.src.Resolutions;

public class AutomorphicNumberSpecialNumbersSeries6
{
    public static string Automorphic(int n) =>
        (n * n).ToString().EndsWith(n.ToString()) ? "Automorphic" : "Not!!";
}
