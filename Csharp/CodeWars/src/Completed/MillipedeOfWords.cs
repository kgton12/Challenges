namespace CodeWars.Completed;

public class MillipedeOfWords
{
    public static bool Millipede(string[] arr)
    {
        var result = new List<string>();
        Exchange(arr, 0, result);

        foreach (var item in result)
        {
            bool isMatch = true;
            List<string> words = [.. item.Split(" ")];

            for (int i = 1; i < words.Count; i++)
            {
                if (words[i].First() == words[i - 1].Last())
                    continue;
                else
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
                return isMatch;
        }

        return false;
    }

    static void Exchange(string[] arr, int start, List<string> result)
    {
        if (start == arr.Length - 1)
        {
            result.Add(string.Join(" ", arr));
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            (arr[start], arr[i]) = (arr[i], arr[start]);
            Exchange(arr, start + 1, result);
            (arr[start], arr[i]) = (arr[i], arr[start]);
        }
    }
}