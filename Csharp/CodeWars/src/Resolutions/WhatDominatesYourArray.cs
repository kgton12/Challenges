namespace CodeWars.Resolutions;

public class WhatDominatesYourArray
{
    public static int WhoDominates(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return -1;

        int n = arr.Length;

        var dominator = arr
            .GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(g => g.Count)
            .FirstOrDefault();

        if (dominator != null && dominator.Count > n / 2)
            return dominator.Value;

        return -1;
    }
}
