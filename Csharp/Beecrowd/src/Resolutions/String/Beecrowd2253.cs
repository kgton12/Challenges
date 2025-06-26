using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2253
{
    public static void PasswordValidator()
    {
        Regex pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{6,32}$");

        while (true)
        {
            string valueLine = Console.ReadLine() ?? string.Empty;

            if (valueLine.Length == 0)
                break;

            Console.WriteLine(pattern.IsMatch(valueLine) ? "Senha valida." : "Senha invalida.");
        }
    }
}