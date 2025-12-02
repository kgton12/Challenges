namespace CodeWars.src.Resolutions;

public class GeometricProgressionSequence
{
    public static string GeometricSequenceElements(int a, int r, int n)
    {
        List<int> result = [a];

        while (result.Count != n)
            result.Add(result.Last() * r);

        return string.Join(", ", result);
    }
}