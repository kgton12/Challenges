namespace CodeWars.Completed;

public class CesrdStrings
{
    public static string Uncensor(string infected, string discovered)
    {
        var discoveredQueue = new Queue<char>(discovered);

        return string.Concat(infected.Select(x =>
        {
            if (x.Equals('*'))
                return discoveredQueue.Dequeue();
            else
                return x;
        }));
    }
}
