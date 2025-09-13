using System;

namespace CodeWars.src.Resolutions;

public class MinmaxminBoundedNums
{
    public static int[] MinMinMax(int[] array)
    {
        int minimumValue = array.Min();
        int maximumValue = array.Max();

        for (int i = minimumValue + 1; i < maximumValue - 1; i++)
            if (!array.Contains(i))
                return [minimumValue, i, maximumValue];

        return [];
    }
}
