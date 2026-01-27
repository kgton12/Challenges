namespace CodeWars.Resolutions;

public class SimpleFun152InviteMoreWomen
{
    public static bool InviteMoreWomen(int[] L) =>
        L.Count(x => x == -1) < L.Count(x => x == 1);
}

