namespace CodeWars.src.Resolutions;

internal class MultiplicationTableForNumber
{
    public static string MultiTable(int number) =>
        string.Join("\n", Enumerable.Range(1, 10).Select(x => $"{x} * {number} = {x * number}"));
}
