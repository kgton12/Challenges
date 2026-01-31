using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public static class SimpleFun176ReverseLetter
{
    public static string ReverseLetter(string str)
    {
        string formatedStr = Regex.Replace(str, "[^a-zA-Z]", "");

        return string.Join("", formatedStr.ToArray().Reverse());
    }
}

