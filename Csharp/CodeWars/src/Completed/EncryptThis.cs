namespace CodeWars.Completed;

public class EncryptThisClass
{
    public static string EncryptThis(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;

        return string.Join(" ", input.Split(' ')
            .Select(word =>
            {
                if (string.IsNullOrEmpty(word)) return "";

                int ascii = word[0];

                if (word.Length == 1)
                    return ascii.ToString();

                if (word.Length == 2)
                    return ascii + word[1].ToString();

                string second = word[1].ToString();

                var last = word[^1].ToString();
                string middle = word.Length > 3 ? word[2..^1] : "";

                return ascii + last + middle + second;
            }));
    }
}
