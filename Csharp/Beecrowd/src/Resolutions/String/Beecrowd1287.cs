using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public static class Beecrowd1287
{
    public static void FriendlyIntegerProcessor()
    {
        int index = 0;
        while (true)
        {
            if (index == 36601) break;

            string lineValue = Console.ReadLine() ?? string.Empty;

            string normalizedLineValue = lineValue.Replace("o", "0")
                .Replace("O", "0")
                .Replace("l", "1")
                .Replace(",", "")
                .Replace(" ", "")
                .Trim();

            bool isValidNumber = !Regex.IsMatch(normalizedLineValue, "[a-zA-Z]") &&
                int.TryParse(normalizedLineValue, out _) &&
                ulong.Parse(normalizedLineValue) <= 2147483647 &&
                normalizedLineValue.Trim() != string.Empty &&
                Convert.ToInt32(normalizedLineValue) >= 0;

            if (isValidNumber)
                Console.WriteLine(ulong.Parse(normalizedLineValue));
            else
                Console.WriteLine("error");

            index++;
        }
    }
}
