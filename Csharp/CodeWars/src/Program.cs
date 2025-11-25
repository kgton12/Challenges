using CodeWars.src;
using CodeWars.src.Model;


Metrics metrics = new();
metrics.Start();

foreach (var item in DigitalCypher.Encode("masterpiece", 1939))
{
    Console.WriteLine(item);
}





metrics.Stop();
