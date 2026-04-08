namespace CodeWars.Completed
{
    public class EnumerableMagic1TrueForAll
    {
        public static bool All(int[] arr, Func<int, bool> fun) => arr.All(fun);
    }
}
