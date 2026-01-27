namespace CodeWars.Resolutions;

public static class EnumerableMagic2TrueForAny
{
    public static bool Any(int[] arr, Func<int, bool> fun) => arr.Any(fun);
}