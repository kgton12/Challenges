namespace CodeWars.Completed;

public class LastSurvivorClass
{
    public static string LastSurvivor(string letters, int[] coords)
    {
        var letterList = letters.ToList();
        foreach (var index in coords)
            letterList.RemoveAt(index);

        return new string([.. letterList]);
    }
}
