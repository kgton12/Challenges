using CodeWars.src.Model;
using CodeWars.src.Resolutions;


Metrics metrics = new();
metrics.Start();

Console.WriteLine(SimpleFun136MissingValues.MissingValues([1, 1, 1, 2, 2, 3]));

metrics.Stop();
