namespace CodeWars.Resolutions;

public class ComplementaryDNA
{
    public static string MakeComplement(string dna)
    {
        Dictionary<char, char> complementary = new()
        {
            { 'A', 'T' },
            { 'T', 'A' },
            { 'C', 'G' },
            { 'G', 'C' }
        };

        return string.Concat(dna.Select(x => complementary[x]));
    }
}
