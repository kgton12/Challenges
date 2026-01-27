using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class FixMyPhoneNumbers
{
    public static string IsItANum(string str)
    {
        string clearNumber = Regex.Replace(str, "[^0-9]", "");

        return clearNumber.Length == 11 && clearNumber[0] == '0'
            ? clearNumber
            : "Not a phone number";
    }
}
