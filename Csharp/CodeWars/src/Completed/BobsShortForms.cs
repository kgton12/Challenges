namespace CodeWars.Completed;

public static class BobsShortForms
{
    public static string ShortForm(string str)
    {
        string vowels = "aeiou";

        return string.Concat(
            str.Where((c, i) =>
            {
                if ((i == 0 || i == str.Length - 1) && vowels.Contains(c, StringComparison.OrdinalIgnoreCase))
                    return true;

                return !vowels.Contains(c, StringComparison.OrdinalIgnoreCase);
            })
        );
    }
}
