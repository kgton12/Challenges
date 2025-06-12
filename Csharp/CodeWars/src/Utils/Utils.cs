namespace CodeWars.src.Utils
{
    public class Utils
    {
        public static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
