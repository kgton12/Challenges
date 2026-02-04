namespace CodeWars.Resolutions;

public class DisariumNumberSpecialNumbersSeries3
{
    public static string DisariumNumber(int number) =>
        number
        .ToString()
        .Select((value, index) => Math.Pow(char.GetNumericValue(value), index + 1))
        .Sum() == number
        ? "Disarium !!"
        : "Not !!";
}
