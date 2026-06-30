namespace CodeWars.Completed;

public class IntegerDepth
{
    public static int ComputeDepth(int n)
    {
        HashSet<int> result = [];
        int i = 0;

        do
        {
            i++;
            (i * n).ToString().ToList().ForEach(x => result.Add((int)char.GetNumericValue(x)));
        } while (result.Count < 10);

        return i;
    }
}
