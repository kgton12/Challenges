namespace CodeWars.src.Utils
{
    public class Utils
    {
        public static void Print(object[] value)
        {
            Console.WriteLine($"[{string.Join(", ", value.ToArray())}]");
        }
    }
}
