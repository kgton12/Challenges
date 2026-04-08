namespace CodeWars.Completed;

public class IfYouCantSleepJustCountSheep
{
    public static string CountSheep(int n) =>
        string.Concat(Enumerable.Range(1, n).Select(x => $"{x} sheep..."));
}
