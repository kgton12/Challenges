namespace CodeWars.Resolutions;

public class FilterOutTheGeese
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        string[] geese = ["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"];

        return birds.Where(x => !geese.Contains(x));
    }
}
