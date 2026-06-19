using System.Globalization;

namespace CodeWars.Completed;

public class GroupedByCommas
{
    public static string GroupByCommas(int n) =>
         n.ToString("N0", new CultureInfo("en-US"));
}