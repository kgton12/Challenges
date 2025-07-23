namespace CodeWars.src.Resolutions
{
    public class SwitcherooClass
    {
        public static string Switcheroo(string x) =>
            string.Concat(x.Select(x =>
            {
                if (x.Equals('a')) return 'b';
                else if (x.Equals('b')) return 'a';
                else
                    return x;
            }));
    }
}
