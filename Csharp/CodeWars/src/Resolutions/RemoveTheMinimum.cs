namespace CodeWars.Resolutions;

public class RemoveTheMinimum
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count == 0) return [];

        numbers.Remove(numbers.Min());
        return numbers;
    }
}

