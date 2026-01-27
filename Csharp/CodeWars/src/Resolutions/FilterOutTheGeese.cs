namespace CodeWars.Resolutions;

public class FilterOutTheGeese
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        return birds.Except(birds);
    }
}
