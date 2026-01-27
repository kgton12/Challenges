namespace CodeWars.Resolutions;

public class WhatIsBetween
{
    public static int[] Between(int a, int b)
    {
        List<int> result = [];

        for (int i = a; i <= b; i++)
            result.Add(i);

        return [.. result];
    }
}
