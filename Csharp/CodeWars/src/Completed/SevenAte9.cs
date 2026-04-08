using System.Text;

namespace CodeWars.Completed;

public class SevenAte9Class
{
    public static string SevenAteNine(string str)
    {
        if (str.Length < 3) return str;

        var stringBuilder = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            if (
                i > 0 &&
                i < str.Length - 1 &&
                str[i - 1] == '7' &&
                str[i] == '9' &&
                str[i + 1] == '7'
            )
                continue;

            stringBuilder.Append(str[i]);
        }

        return stringBuilder.ToString();
    }
}
