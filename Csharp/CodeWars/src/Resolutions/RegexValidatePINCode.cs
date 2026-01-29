namespace CodeWars.Resolutions;

public static class RegexValidatePINCode
{
    public static bool ValidatePin(string pin) =>
         pin.All(char.IsDigit) && (pin.Length == 4 || pin.Length == 6);
}