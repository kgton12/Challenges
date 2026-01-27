using System.Text.RegularExpressions;

namespace CodeWars.Resolutions
{
    public class ChangingLetters
    {
        public static string Swap(string s) => Regex.Replace(s, "[aeiou]", m => m.Value.ToUpper());
    }
}