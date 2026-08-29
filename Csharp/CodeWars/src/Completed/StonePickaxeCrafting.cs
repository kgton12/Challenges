namespace CodeWars.Completed;

public class StonePickaxeCrafting
{
    public static int StonePick(string[] arr)
    {
        int sumCobblestones = arr.Count(x => x == "Cobblestone");
        int sumSticks = arr.Count(x => x == "Sticks");
        sumSticks += arr.Count(x => x == "Wood") * 4;

        return Math.Min(sumCobblestones / 3, sumSticks / 2);
    }
}