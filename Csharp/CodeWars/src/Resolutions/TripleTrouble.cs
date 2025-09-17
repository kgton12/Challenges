namespace CodeWars.src.Resolutions
{
    public class TripleTroubleClass
    {
        public static string TripleTrouble(string one, string two, string three) =>
            string.Concat(Enumerable.Range(0, one.Length).Select(x => $"{one[x]}{two[x]}{three[x]}"));
    }
}
