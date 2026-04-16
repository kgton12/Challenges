namespace CodeWars.Completed;

public class ThinkingTestingUniqOrNotUniq
{
    public static int[] Testit(int[] a, int[] b) =>
        [..a
            .Distinct()
            .Concat(b.Distinct())
            .OrderBy(x => x)
        ];
}
