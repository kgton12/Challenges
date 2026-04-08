namespace CodeWars.Completed;

public class LarioAndMuigiPipeProblem
{
    public static List<int> PipeFix(List<int> numbers) =>
        [.. Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1)];
}
