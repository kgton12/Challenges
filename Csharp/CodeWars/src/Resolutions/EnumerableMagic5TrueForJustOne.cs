namespace CodeWars.Resolutions;

public class EnumerableMagic5TrueForJustOne
{
    public static bool One(int[] arr, Func<int, bool> fun) =>
        arr.Count(fun) == 1;
}
