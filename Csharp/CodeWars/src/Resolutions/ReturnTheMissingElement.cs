namespace CodeWars.Resolutions;

public class ReturnTheMissingElement
{
    public static int GetMissingElement(int[] superImportantArray) => Enumerable.Range(0, 10).Except(superImportantArray).FirstOrDefault();
}
