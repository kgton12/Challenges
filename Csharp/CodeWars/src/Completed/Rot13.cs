namespace CodeWars.Completed;

public static class Rot13Class
{
    public static string Rot13(string message)
    {
        List<char> result = [];

        for (int i = 0; i < message.Length; i++)
        {
            char c = message[i];

            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                result.Add((char)((c - baseChar + 13) % 26 + baseChar));
            }
            else
                result.Add(c);
        }

        return string.Concat(result);
    }
}
