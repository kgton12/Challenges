namespace CodeWars.Completed;

public class AlphabeticalAddition
{
    public static char AddLetters(char[] letters)
    {
        if (letters == null || letters.Length == 0)
            return 'z';

        int sum = letters.Sum(GetAlphabetPosition);
        int mod = (sum - 1) % 26 + 1;
        return (char)(mod + 96);
    }

    private static int GetAlphabetPosition(char c) =>
        char.ToLower(c) - 'a' + 1;
}
