using System.Text;

namespace CodeWars.Completed;

public class OneDownClass
{
    public static string OneDown(string str)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        StringBuilder result = new();

        foreach (var chr in str)
        {
            int i = alphabet.IndexOf(chr);

            if (chr == 'A')
                result.Append('z');
            else if (chr == ' ')
                result.Append(chr);
            else
                result.Append(alphabet[i - 1]);
        }

        return result.ToString();
    }
}