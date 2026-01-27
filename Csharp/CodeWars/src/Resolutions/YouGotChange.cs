namespace CodeWars.Resolutions;

public class YouGotChange
{
    private static readonly int[] banknotes = [100, 50, 20, 10, 5, 1];
    public static int[] GiveChange(int amount)
    {
        List<int> result = [];
        int aux;

        foreach (var item in banknotes)
        {
            aux = amount / item;
            result.Add(aux);
            amount -= aux * item;
        }

        return [.. result.AsEnumerable().Reverse()];
    }
}