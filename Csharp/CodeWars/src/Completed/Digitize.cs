namespace CodeWars.Completed;

public class DigitizeClass
{
    public static int[] Digitize(int n) =>
        [.. n.ToString().Select(x => (int)char.GetNumericValue(x))];
}
