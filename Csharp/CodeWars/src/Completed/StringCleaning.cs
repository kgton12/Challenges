using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class StringCleaning
{
    public static string StringClean(string s) => Regex.Replace(s, "[0-9]", "");
}
