namespace CodeWars.Completed;

public class PrintCountAndNumbers
{
    public static string CountMe(string data)
    {
        if (string.IsNullOrEmpty(data) || data.Any(c => !char.IsDigit(c)))
            return string.Empty;

        var runs = data.Aggregate(
            new List<string>(),
            (list, ch) =>
            {
                if (list.Count == 0 || list[^1][0] != ch)
                    list.Add(ch.ToString());
                else
                    list[^1] += ch;
                return list;
            });

        return string.Concat(runs.Select(r => $"{r.Length}{r[0]}"));
    }
}