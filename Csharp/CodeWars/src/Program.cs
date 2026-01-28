using CodeWars.Resolutions;
using CodeWars.Service;

Metrics metrics = new();
metrics.Start();

foreach (var item in FilterOutTheGeese.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }))
{
    Console.WriteLine(item);
}

//Console.WriteLine(FilterOutTheGeese.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }));

Console.ReadKey();

metrics.Stop();