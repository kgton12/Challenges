namespace CodeWars.Completed;

public class NoOdditiesHere
{
    public static int[] NoOdds(int[] values)
    {
        return [.. values.ToList().Where(value => value % 2 == 0)];
    }
}

