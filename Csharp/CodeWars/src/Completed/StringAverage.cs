namespace CodeWars.Completed;

public class StringAverage
{
    private static readonly Dictionary<string, int> valuePairs =
        new()
        {
            ["zero"] = 0,
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4,
            ["five"] = 5,
            ["six"] = 6,
            ["seven"] = 7,
            ["eight"] = 8,
            ["nine"] = 9
        };
    public static string AverageString(string str)
    {
        string[] splitedStr = str.Split(' ');

        if (string.IsNullOrEmpty(str.Trim()) || !splitedStr.All(x => valuePairs.TryGetValue(x, out int _)))
            return "n/a";

        int avg = (int)splitedStr.Average(x => valuePairs.TryGetValue(x, out int value) ? value : 0);

        return valuePairs.FirstOrDefault(x => x.Value == avg).Key;
    }
}