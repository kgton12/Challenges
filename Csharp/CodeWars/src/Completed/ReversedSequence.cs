namespace CodeWars.Completed;

public class ReversedSequence
{
    public static int[] ReverseSeq(int n) =>
        [.. Enumerable.Range(1, n).Reverse()];
}
