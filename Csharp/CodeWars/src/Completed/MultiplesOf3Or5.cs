namespace CodeWars.Completed;

public class MultiplesOf3Or5
{
    public static int Solution(int value) =>
        value > 0
            ? Enumerable.Range(1, value - 1).Where(x => x % 3 == 0 || x % 5 == 0).Distinct().Sum()
            : 0;
}
