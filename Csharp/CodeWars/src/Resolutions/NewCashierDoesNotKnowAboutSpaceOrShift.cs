using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class NewCashierDoesNotKnowAboutSpaceOrShift
{
    public static string GetOrder(string input)
    {
        string[] menu = ["Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"];
        List<string> result = [];

        foreach (var item in menu)
        {
            var pattern = new Regex(item, RegexOptions.IgnoreCase);

            var matchedPatternCount = pattern.Matches(input).Count;

            for (int i = 0; i < matchedPatternCount; i++)
                result.Add(item);
        }
        return string.Join(" ", result);
    }
}
