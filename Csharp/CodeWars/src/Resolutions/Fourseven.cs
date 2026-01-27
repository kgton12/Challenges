namespace CodeWars.Resolutions;

public class FoursevenClass
{
    public static int FourSeven(int num)
    {
        var acceptableValues = new[]
        {
            new { Key = 4, Value = 7 },
            new { Key = 7, Value = 4 }
        };

        return acceptableValues
            .Where(x => x.Key == num)
            .Select(x => x.Value)
            .FirstOrDefault(0);
    }
}
