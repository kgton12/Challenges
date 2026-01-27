namespace CodeWars.Resolutions;

public class RegexValidatePINCode
{
    public static bool ValidatePin(string pin) =>
         pin.All(char.IsDigit) && (pin.Length == 4 || pin.Length == 6);
}