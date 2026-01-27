using CodeWars.Resolutions;
using CodeWars.Service;

Metrics metrics = new();
metrics.Start();

//foreach (var item in StringBasics.GetUserIds("multipleuid"))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(InvalidInputErrorHandling1.GetCount("Aa"));

Console.ReadKey();

metrics.Stop();