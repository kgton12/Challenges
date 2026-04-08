using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class ExtractPortionOfFileName
{
    public static string ExtractFileName(string dirtFileName)
    {
        var match = Regex.Match(dirtFileName, @"^\d+_(.+?)\.[^\.]+$");

        return match.Groups[1].Value;
    }
}
