namespace CodeWars.Resolutions;

public class CalculateMeanAndConcatenateString
{
    public static object[] Mean(char[] lst)
    {
        string word = string.Concat(lst.Where(char.IsAsciiLetter));
        double avg = lst.Where(char.IsDigit).Average(char.GetNumericValue);

        return [avg, word];
    }
}
