namespace CodeWars.Resolutions;

public class EanValidation
{
    readonly static int[] eanValues = [1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1];
    public static bool Validate(string eanCode)
    {
        int sum = (int)eanCode
                       .Select((n, i) => char.GetNumericValue(n) * eanValues[i])
                       .Sum();

        char checkDigit = (10 - (sum % 10)).ToString().Last();

        return eanCode.Last() == checkDigit;
    }
}