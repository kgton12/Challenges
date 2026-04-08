namespace CodeWars.Completed
{
    public class DoubleCharClass
    {
        public static string DoubleChar(string s) =>
            string.Concat(s.Select(x => new string(x, 2)));
    }
}
