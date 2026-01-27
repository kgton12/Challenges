using System.Text.RegularExpressions;

namespace CodeWars.Resolutions
{
    public class SimpleValidationOfAUserNameWithRegex
    {
        public static bool ValidateUsr(string username)
        {
            var regex = new Regex("^[a-z0-9_]{4,16}$");

            return regex.IsMatch(username);
        }
    }
}
