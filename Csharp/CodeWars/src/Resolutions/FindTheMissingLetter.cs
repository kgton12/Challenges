namespace CodeWars.Resolutions;

public class FindTheMissingLetter
{
    public static char FindMissingLetter(char[] array) =>
        (char)Enumerable
        .Range(array[0], array[^1])
        .Where(x => !array.Contains((char)x))
        .First();
}
