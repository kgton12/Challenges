namespace CodeWars.Resolutions;

public class HelpTheBookseller
{
    public static string StockSummary(string[] lstOfArt, string[] lstOf1stLetter)
    {
        if (lstOf1stLetter.Length == 0 || lstOfArt.Length == 0)
            return string.Empty;

        List<string> result = [];

        foreach (var letter in lstOf1stLetter)
        {
            string[] startedWith = [.. lstOfArt.Where(x => x.StartsWith(letter))];
            int sum = startedWith.Sum(x => Convert.ToInt32(x.Split(' ')[1]));

            result.Add($"({letter} : {sum})");
        }

        return string.Join(" - ", result);
    }
}
