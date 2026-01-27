using System.Diagnostics;

namespace CodeWars.Service;

public class Metrics
{
    private Stopwatch StopWatch { get; set; } = new();

    public void Start() =>
        StopWatch.Start();

    public void Stop()
    {
        StopWatch.Stop();
        Console.WriteLine($"Tempo decorrido: {StopWatch.ElapsedMilliseconds} ms");
    }
}