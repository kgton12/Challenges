namespace CodeWars.Resolutions;

public class ReplaceEveryNth
{
    public static string ReplaceNth(string text, int n, char oldValue, char newValue)
    {
        int foundCount = 1;
        char[] newText = text.ToCharArray();

        for (int i = 0; i < newText.Length; i++)
        {
            if (text[i].Equals(oldValue))
            {
                if (foundCount == n)
                {
                    newText[i] = newValue;
                    foundCount = 1;
                    continue;
                }

                foundCount++;
            }
        }

        return string.Concat(newText);
    }
}
