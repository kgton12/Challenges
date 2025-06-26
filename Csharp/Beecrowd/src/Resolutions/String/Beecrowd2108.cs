namespace BeeCrowd.src.Resolutions.String;

public static class Beecrowd2108
{
    public static void CountingCharacters()
    {
        string biggestName = "";
        while (true)
        {
            string lineValue = Console.ReadLine() ?? string.Empty;

            if (lineValue == "0") break;

            string result = string.Join("-", lineValue.Split(" ")
            .Select(x =>
            {
                biggestName = x.Length >= biggestName.Length ? x : biggestName;
                return x.Length;
            }));

            Console.WriteLine(result);
        }

        Console.WriteLine("");
        Console.WriteLine($"The biggest word: {biggestName}");
    }
}
