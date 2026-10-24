namespace CodeWars.Completed;

public static class RegexpBasicsIsItAEightBitSignedNumber
{
    public static bool SignedEightBitNumber(this string s) =>
        sbyte.TryParse(s, out sbyte val)
        && val.ToString().Equals(s);
}
