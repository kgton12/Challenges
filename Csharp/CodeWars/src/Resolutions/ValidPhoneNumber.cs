namespace CodeWars.Resolutions;

public class ValidPhoneNumberClass
{
    public static bool ValidPhoneNumber(string phoneNumber)
    {
        if (phoneNumber.StartsWith('(') && phoneNumber.IndexOf(')') == 4 &&
            phoneNumber.Length == 14 && phoneNumber.IndexOf('-') == 9 &&
            phoneNumber.IndexOf(' ') == 5 &&
            phoneNumber.Where(char.IsDigit).Count() == 10) return true;
        return false;
    }
}
