namespace CodeWars.Completed;

public class InternationalMorseCodeEncryption
{
    private static readonly Dictionary<char, string> morse =
        new()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
            {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
            {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."},{' ', " "},
            {'0', "-----"}, {'1', ".----"},{'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
            {'8', "---.."}, {'9', "----."}
        };

    public static string ToMorse(string englishStr) =>
        string.Join(" ",
                englishStr
                    .ToUpper()
                    .Select(x => morse.TryGetValue(x, out string? value) ? value : string.Empty)
            );
}