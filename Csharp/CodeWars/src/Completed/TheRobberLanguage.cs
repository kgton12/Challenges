using System.Text;

namespace CodeWars.Completed;

public class TheRobberLanguage
{
    public static string RobberEncode(string sentence)
    {
        string vowels = "BCDFGHJKLMNPQRSTVWXYZ";
        StringBuilder result = new();
        string o = "o";

        foreach (var item in sentence)
        {
            if (vowels.Contains(item, StringComparison.CurrentCultureIgnoreCase))
                result.Append($"{item}{(char.IsUpper(item) ? o.ToUpper() : o)}{item}");
            else
                result.Append(item);
        }

        return result.ToString();
    }
}