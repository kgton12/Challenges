namespace CodeWars.Completed;

public class MultiplicationTableForNumber
{
    public static string MultiTable(int number) =>
        string.Join("\n", Enumerable.Range(1, 10).Select(x => $"{x} * {number} = {x * number}"));
}
