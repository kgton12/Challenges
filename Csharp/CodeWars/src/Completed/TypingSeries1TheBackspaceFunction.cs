using System.Text;

namespace CodeWars.Completed;

public class TypingSeries1TheBackspaceFunction
{
    public static string Solve(string s)
    {
        string BackspaceToken = "[backspace]";
        var result = new StringBuilder();
        int index = 0;

        while (index < s.Length)
        {
            bool isBackspace = s.IndexOf(BackspaceToken, index, StringComparison.Ordinal) == index;

            if (!isBackspace)
            {
                result.Append(s[index]);
                index++;
                continue;
            }

            index += BackspaceToken.Length;

            int repetitions = 1;

            if (index < s.Length && s[index] == '*')
            {
                index++;

                int numberStart = index;

                while (index < s.Length && char.IsDigit(s[index]))
                {
                    index++;
                }

                repetitions = int.Parse(s[numberStart..index]);
            }

            for (int count = 0; count < repetitions; count++)
            {
                if (result.Length == 0)
                {
                    break;
                }

                result.Length--;
            }
        }

        return result.ToString();
    }
}