namespace CodeWars.src.Resolutions;

public class MaxminArrays
{
    public static List<int> Solve(List<int> arr)
    {
        List<int> result = [];
        List<int> orderedArray = [.. arr.OrderBy(x => x)];
        int l = 0;
        int r = arr.Count - 1;

        while (l < r)
        {
            result.Add(orderedArray[r]);
            result.Add(orderedArray[l]);
            l++;
            r--;
        }

        if (l == r)
            result.Add(orderedArray[l]);

        return result;
    }
}
