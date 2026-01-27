namespace CodeWars.Resolutions;

public class SimpleBeadsCount
{
    public static int CountRedBeads(int n)
    {
        return n > 2 ? n * 2 - 2 : 0;
    }
}
