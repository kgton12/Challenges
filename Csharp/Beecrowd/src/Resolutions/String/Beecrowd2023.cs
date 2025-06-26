namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2023
{
    public static void TheLastGoodChild()
    {
        List<string> names = new List<string>();
        while (true)
        {
            string lineValue = Console.ReadLine() ?? string.Empty;

            if (lineValue.Trim() == "") break;

            names.Add(lineValue);
        }

        Console.WriteLine(names.OrderByDescending(x => x.ToLower()).First());
    }
}