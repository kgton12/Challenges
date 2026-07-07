using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class MessageValidator
{
    public static bool IsAValidMessage(string message)
    {
        var matches = Regex.Matches(message, @"(\d+)([^\d]*)");

        foreach (Match m in matches)
        {
            int qtd = Convert.ToInt32(m.Groups[1].Value);
            string value = m.Groups[2].Value;

            if (qtd != value.Length)
                return false;
        }
        return true;
    }
}