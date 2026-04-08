namespace CodeWars.Completed;

public static class CharacterWithLongestConsecutiveRepetition
{
    public static Tuple<char?, int> LongestRepetition(string input)
    {
        if (string.IsNullOrEmpty(input))
            return Tuple.Create<char?, int>(null, 0);

        char? maxChar = null;
        int maxLen = 0;

        char currentChar = input[0];
        int currentLen = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
                currentLen++;
            else
            {
                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                    maxChar = currentChar;
                }

                currentChar = input[i];
                currentLen = 1;
            }
        }

        if (currentLen > maxLen)
        {
            maxLen = currentLen;
            maxChar = currentChar;
        }

        return Tuple.Create(maxChar, maxLen);
    }
}