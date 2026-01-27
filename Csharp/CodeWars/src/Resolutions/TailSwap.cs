namespace CodeWars.Resolutions;

public class TailSwapClass
{
    public static string[] TailSwap(string[] arr)
    {
        string[] parts1 = arr[0].Split(':');
        string[] parts2 = arr[1].Split(':');

        return
        [
            $"{parts1[0]}:{parts2[1]}",
            $"{parts2[0]}:{parts1[1]}"
        ];
    }
}