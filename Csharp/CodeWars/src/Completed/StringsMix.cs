using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public static class StringsMix
{
    private class MixItem
    {
        public char Letter { get; set; }
        public int Quantity { get; set; }
        public string Local { get; set; } = "";
    }

    private static readonly Regex NonLowercaseRegex = new Regex("[^a-z]", RegexOptions.Compiled);

    public static string Mix(string s1, string s2)
    {
        var output = new List<MixItem>();

        var letters1 = NonLowercaseRegex.Replace(s1 ?? string.Empty, string.Empty).ToCharArray();
        var letters2 = NonLowercaseRegex.Replace(s2 ?? string.Empty, string.Empty).ToCharArray();

        var letterSet = new HashSet<char>(letters1.Concat(letters2));

        foreach (var letter in letterSet.Where(ch => ch >= 'a' && ch <= 'z'))
        {
            var countS1 = CountLetter(s1, letter);
            var countS2 = CountLetter(s2, letter);

            var item = new MixItem
            {
                Letter = letter
            };

            if (countS1 > countS2)
            {
                item.Quantity = countS1;
                item.Local = "1";
            }
            else if (countS2 > countS1)
            {
                item.Quantity = countS2;
                item.Local = "2";
            }
            else
            {
                item.Quantity = countS1;
                item.Local = "=";
            }

            output.Add(item);
        }

        var result = output
            .Where(x => x.Quantity > 1)
            .OrderByDescending(x => x.Quantity)
            .ThenBy(x => LocalOrder(x.Local))
            .ThenBy(x => x.Letter)
            .Select(x => $"{x.Local}:{new string(x.Letter, x.Quantity)}");

        return string.Join("/", result);
    }

    private static int CountLetter(string? s, char letter)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        int count = 0;
        foreach (var ch in s)
        {
            if (ch == letter) count++;
        }
        return count;
    }

    private static int LocalOrder(string local)
    {
        return local switch
        {
            "1" => 0,
            "2" => 1,
            "=" => 2,
            _ => 3
        };
    }
}