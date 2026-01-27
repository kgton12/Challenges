namespace CodeWars.Resolutions;

public class NameArrayCapping
{
    public static string[] CapMe(string[] strings) =>
        [.. strings.Select(x => string.Concat(x[0].ToString().ToUpper(), x.ToLower().AsSpan(1)))];
}
