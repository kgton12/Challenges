namespace CodeWars.Completed;

public class HandsUp
{
    public static int[] GetPositions(int s) =>
        [
            s % 3,
            (s / 3) % 3,
            (s / 9) % 3
        ];
}