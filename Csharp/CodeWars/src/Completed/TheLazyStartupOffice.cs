namespace CodeWars.Completed;

public class TheLazyStartupOffice
{
    public static string[] BinRota(string[][] input) =>
        [.. input
            .SelectMany((x, i) => i % 2 == 0 ? x : x.Reverse())
        ];
}