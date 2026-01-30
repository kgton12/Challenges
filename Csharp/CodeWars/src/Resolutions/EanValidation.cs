namespace CodeWars.Resolutions;

public class EanValidation
{
    readonly static int[] eanValues = { 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };

    public static bool Validate(string eanCode)
    {
        if (eanCode.Length != 13 || !eanCode.All(char.IsDigit))
            return false;

        int sum = eanCode
                    .Take(12)
                    .Select((n, i) => (int)char.GetNumericValue(n) * eanValues[i])
                    .Sum();

        int mod = sum % 10;
        int checkDigit = (mod == 0) ? 0 : 10 - mod;

        return char.GetNumericValue(eanCode.Last()) == checkDigit;
    }
}