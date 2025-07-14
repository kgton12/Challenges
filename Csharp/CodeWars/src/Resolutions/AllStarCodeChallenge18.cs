namespace CodeWars.src.Resolutions;

public class AllStarCodeChallenge18
{
    public static int StrCount(string str, char letter) =>
        str.Count(x => x.Equals(letter));
}
