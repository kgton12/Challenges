namespace CodeWars.Completed;

public static class OperationsWithSequence
{
    public static int Calc(int[] array) =>
        array
            .Select((n) => n > 0 ? n * n : n)
            .Select((n, i) => (i + 1) % 3 == 0 ? n * 3 : n)
            .Select((n, i) => (i + 1) % 5 == 0 ? -n : n)
            .Sum();
}