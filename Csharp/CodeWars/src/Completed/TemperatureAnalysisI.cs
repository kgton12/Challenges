namespace CodeWars.Completed;

public class TemperatureAnalysisI
{
    public static int? LowestTemperature(string t) =>
        string.IsNullOrEmpty(t)
            ? null
            : t.Split(' ').Min(x => Convert.ToInt32(x));
}
