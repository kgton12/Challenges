namespace CodeWars.Completed;

public static class Basics02StringArrayResult
{
    public static string CalculateArray(string stringArray)
    {
        var t = stringArray
                          .Split(';', StringSplitOptions.RemoveEmptyEntries)
                          .Where(x => int.TryParse(x, out int _));

        var avgOfValues = Math.Round(stringArray
                          .Split(';')
                          .Where(x => int.TryParse(x, out int _))
                          .Average(x => Convert.ToInt32(x)));

        var sumCharValues = avgOfValues
                            .ToString()
                            .Sum(x => Convert.ToInt32(char.GetNumericValue(x)));

        var resultIsDivisibleFor5 = sumCharValues % 5 == 0;

        return string.Join(',',
                avgOfValues.ToString(),
                sumCharValues,
                resultIsDivisibleFor5.ToString().ToUpper()
        );
    }
}