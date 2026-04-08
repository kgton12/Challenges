namespace CodeWars.Completed;

public class CompoundArrayClass
{
    public static int[] CompoundArray(int[] a, int[] b)
    {
        int sizeOfBiggerfArray = Math.Max(a.Length, b.Length);
        List<int> result = [];


        for (int i = 0; i < sizeOfBiggerfArray; i++)
        {
            if (i < a.Length)
                result.Add(a[i]);

            if (i < b.Length)
                result.Add(b[i]);
        }

        return [.. result];
    }
}