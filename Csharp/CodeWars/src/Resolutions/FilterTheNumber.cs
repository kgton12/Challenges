using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class FilterTheNumber
{
    public static int FilterString(string s)
    {
        var regex = new Regex("[^0-9]");
        return Convert.ToInt32(regex.Replace(s, ""));
    }
}
