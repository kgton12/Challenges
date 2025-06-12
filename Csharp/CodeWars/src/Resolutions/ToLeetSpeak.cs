namespace CodeWars.src.Resolutions;

public class ToLeetSpeakClass
{
    private static readonly Dictionary<char, char> Lett = new()
    {
        {'A', '@'},
        {'B', '8'},
        {'C', '('},
        {'D', 'D'},
        {'E', '3'},
        {'F', 'F'},
        {'G', '6'},
        {'H', '#'},
        {'I', '!'},
        {'J', 'J'},
        {'K', 'K'},
        {'L', '1'},
        {'M', 'M'},
        {'N', 'N'},
        {'O', '0'},
        {'P', 'P'},
        {'Q', 'Q'},
        {'R', 'R'},
        {'S', '$'},
        {'T', '7'},
        {'U', 'U'},
        {'V', 'V'},
        {'W', 'W'},
        {'X', 'X'},
        {'Y', 'Y'},
        {'Z', '2'}
    };

    public static string ToLeetSpeak(string str)
    {
        return string.Concat(str.Select(x =>
            Lett.TryGetValue(x, out var leetChar) ? leetChar : x
        ));
    }
}
