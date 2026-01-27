namespace CodeWars.Resolutions;

public class GravityFlip
{
    public static int[] Flip(char dir, int[] arr) =>
        [.. dir.Equals('R')
            ? arr.OrderBy(x => x)
            : arr.OrderByDescending(x => x)
        ];
}
