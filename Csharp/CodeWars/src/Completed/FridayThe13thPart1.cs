namespace CodeWars.Completed;

public class FridayThe13thPart1
{
    public static string[] KillCount(Dictionary<string, int> counselors, int jason) =>
    [..
        counselors
            .Where(x => x.Value < jason)
            .Select(x => x.Key)
    ];
}