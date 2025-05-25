namespace CodeWars.src.Resolutions;

public class CountCharactersInYourString
{
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> characters = [];

        str.ToList().ForEach(c => characters[c] = characters.TryGetValue(c, out int value) ? ++value : 1);

        return characters;
    }
}
