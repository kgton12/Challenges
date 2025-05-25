namespace CodeWars.src.Resolutions;

public class SortTheGiftCode
{
    public static string SortGiftCode(string code)
    {
        return string.Join("", code.OrderBy(x => x));
    }
}
