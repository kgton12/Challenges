namespace CodeWars.Completed;

public static class ReturnTheClosestNumberMultipleOf10
{
    public static int ClosestMultiple10(int num) =>
        (int)Math.Round(num / 10.0, MidpointRounding.AwayFromZero) * 10;
}
