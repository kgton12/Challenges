namespace CodeWars.Completed;

public class CalculateStringRotation
{
    public static int ShiftedDiff(string first, string second) =>
        second.Length == first.Length ? (second + second).IndexOf(first) : -1;
}