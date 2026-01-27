namespace CodeWars.Resolutions;

public static class EnumerableMagic4TrueForNone
{
    public static bool None(int[] arr, Func<int, bool> fun) => !arr.Any(fun);
}
