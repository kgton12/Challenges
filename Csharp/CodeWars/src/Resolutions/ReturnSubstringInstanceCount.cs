namespace CodeWars.Resolutions;

public class ReturnSubstringInstanceCount
{
    public static int SubstringCount(string fullText, string searchText) =>
        fullText.Split(searchText).Length - 1;
}
