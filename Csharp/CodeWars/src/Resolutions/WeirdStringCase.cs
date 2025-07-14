namespace CodeWars.src.Resolutions;

public class WeirdStringCase
{
    public static string ToWeirdCase(string s)
    {
        return string.Join(" ",
            s
            .Split(" ")
            .Select(x => string.Concat(
                x
                .Select((value, index) => index % 2 == 0 ? char.ToUpper(value) : char.ToLower(value)))
            )
        );
    }
}
