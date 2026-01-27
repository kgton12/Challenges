namespace CodeWars.Resolutions;

public class FindTheParityOutlier
{
    public static int Find(int[] integers)
    {
        List<int> oddValues = [];
        List<int> evenValues = [];

        foreach (var item in integers)
            if (item % 2 == 0)
                evenValues.Add(item);
            else
                oddValues.Add(item);

        return evenValues.Count == 1 ? evenValues[0] : oddValues[0];
    }
}
