namespace CodeWars.Completed;

public class AssembleString
{
    public static string Assemble(string[] copies)
    {
        if (copies.Length == 0) return "";

        int lineLength = copies[0].Length;
        string result = string.Empty;

        for (int i = 0; i < lineLength; i++)
        {
            char chr = '#';
            for (int j = 0; j < copies.Length; j++)
            {
                string word = copies[j];

                if (word[i] != '*')
                    chr = word[i];
            }

            result += chr;
        }

        return result;
    }
}
