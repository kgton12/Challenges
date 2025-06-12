namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1253
{
    public static void CaesarCipher()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string word = Console.ReadLine() ?? string.Empty;
            int jump = Convert.ToInt32(Console.ReadLine());

            string encryptedWord = string.Concat(word.Select(x => ApplyCaesarShift(x, jump)));

            Console.WriteLine(encryptedWord);
        }
    }

    private static char ApplyCaesarShift(char c, int jump)
    {
        int lastCharacterAlphabet = 91;
        int codeAsciiForA = 65;
        int codeAscii = c;

        if (codeAscii - jump < codeAsciiForA)
            return Convert.ToChar(lastCharacterAlphabet - (codeAsciiForA - (codeAscii - jump)));
        else return Convert.ToChar(codeAscii - jump);
    }
}