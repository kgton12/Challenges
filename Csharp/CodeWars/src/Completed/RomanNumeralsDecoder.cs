namespace CodeWars.Completed;

public class RomanNumeralsDecoder
{
    public static readonly Dictionary<char, int> romanNumerals =
    new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public static int Solution(string roman) =>
        roman.Select((Value, Index) => new { Value, Index }).Sum(x =>
        {
            if (x.Index + 1 == roman.Length)
                return romanNumerals[roman[x.Index]];
            else
            {
                if (romanNumerals[roman[x.Index]] < romanNumerals[roman[x.Index + 1]])
                    return -romanNumerals[roman[x.Index]];
                else
                    return romanNumerals[roman[x.Index]];
            }
        });
}
