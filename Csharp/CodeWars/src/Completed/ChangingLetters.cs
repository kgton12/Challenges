using System.Text.RegularExpressions;

namespace CodeWars.Completed
{
    public class ChangingLetters
    {
        public static string Swap(string s) => Regex.Replace(s, "[aeiou]", m => m.Value.ToUpper());
    }
}