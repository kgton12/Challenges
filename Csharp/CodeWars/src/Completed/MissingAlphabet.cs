namespace CodeWars.Completed;

public class MissingAlphabet
{
    public static string InsertMissingLetters(string str)
    {
        string vivisitedTetters = "";
        string result = "";

        foreach (var c in str.ToLower())
        {
            if (vivisitedTetters.Contains(c))
                result += c;
            else
            {
                vivisitedTetters += c;
                result += FillAphabet(c, str);
            }
        }

        return result;
    }

    private static string FillAphabet(char c, string str)
    {
        string result = "";
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int index = alphabet.IndexOf(c, StringComparison.OrdinalIgnoreCase) + 1;

        result += c;

        for (int i = index; i < alphabet.Length; i++)
        {
            if (str.Contains(alphabet[i], StringComparison.OrdinalIgnoreCase))
                continue;

            result += alphabet[i];
        }

        return result;
    }
}