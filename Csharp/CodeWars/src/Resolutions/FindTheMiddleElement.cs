namespace CodeWars.Resolutions;

public class FindTheMiddleElement
{
    public static int Gimme(double[] inputArray)
    {
        return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
    }
}

