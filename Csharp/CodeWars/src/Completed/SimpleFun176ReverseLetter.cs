using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public static class SimpleFun176ReverseLetter
{
    public static string ReverseLetter(string str)
    {
        string formatedStr = Regex.Replace(str, "[^a-zA-Z]", "");

        return string.Join("", formatedStr.ToArray().Reverse());
    }
}

