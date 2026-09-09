namespace CodeWars.Completed;

public class LoopDetector
{
    public static bool HasLoop(int[] arr)
    {
        HashSet<int> visited = [];
        int index = 0;

        while (index >= 0 && index < arr.Length)
        {
            if (!visited.Add(index))
                return true;

            index = arr[index];
        }

        return false;
    }
}