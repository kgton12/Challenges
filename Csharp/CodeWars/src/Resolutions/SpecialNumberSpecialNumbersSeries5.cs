namespace CodeWars.Resolutions;

public class SpecialNumberSpecialNumbersSeries5
{
    public static string SpecialNumber(int number) =>
        number
        .ToString()
        .All(x => char.GetNumericValue(x) <= 5)
        ? "Special!!"
        : "NOT!!";
}
