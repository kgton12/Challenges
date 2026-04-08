namespace CodeWars.Completed;

public static class ElapsedSecondsClass
{
    public static int ElapsedSeconds(DateTime startDate, DateTime endDate) =>
        (int)(endDate - startDate).TotalSeconds;
}
