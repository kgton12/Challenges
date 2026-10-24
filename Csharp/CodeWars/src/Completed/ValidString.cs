namespace CodeWars.Completed;

public class ValidString
{
    public static bool ValidateWord(string[] dictionary, string word)
    {
        var canBuild = new bool[word.Length + 1];
        canBuild[0] = true;

        for (var start = 0; start < word.Length; start++)
        {
            if (!canBuild[start])
                continue;

            foreach (var item in dictionary)
            {
                if (string.IsNullOrEmpty(item))
                    continue;

                if (start + item.Length > word.Length)
                    continue;

                if (word.AsSpan(start, item.Length)
                    .Equals(item.AsSpan(), StringComparison.InvariantCultureIgnoreCase))
                {
                    canBuild[start + item.Length] = true;
                }
            }
        }

        return canBuild[word.Length];
    }
}
