namespace CodeWars.src.Resolutions;

public class GetTheMiddleCharacter
{
    public static string GetMiddle(string s)
    {
        int middle = s.Length / 2;

        if (s.Length == 1) return s;

        if (s.Length % 2 == 0)
            return s.Substring(middle - 1, 2);
        else
            return s.Substring(middle, 1);
    }
}
