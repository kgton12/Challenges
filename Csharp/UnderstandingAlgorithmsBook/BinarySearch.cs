namespace UnderstandingAlgorithmsBook;

public static class BinarySearch
{
    /// <summary>
    /// Performs a binary search for the specified <paramref name="target"/> in the given integer array.
    /// </summary>
    /// <param name="arr">A sorted array of integers (must be sorted in ascending order).</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>
    /// The zero-based index of <paramref name="target"/> if found; otherwise <c>null</c>.
    /// </returns>
    /// <remarks>
    /// The input array <paramref name="arr"/> must be sorted in ascending order for this algorithm to work correctly.
    /// Time complexity: O(log n).
    /// </remarks>
    public static int? Search(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;
            int kick = arr[middle];

            if (kick == target)
                return middle;

            if (kick > target)
                high = middle - 1;
            else
                low = middle + 1;
        }

        return null;
    }
}