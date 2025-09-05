namespace CodeWars.src.Resolutions;

public class OdderThanTheRest
{
    public static int OddOne(List<int> list) =>
        list.FindIndex(x => x % 2 != 0);
}