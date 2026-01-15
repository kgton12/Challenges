using CodeWars.src;
using CodeWars.src.Model;


Metrics metrics = new();
metrics.Start();

//foreach (var item in AscWeek1Challenge5Medium2.AvgArray(new double[][] { new double[] { 1, 2, 3, 4 }, new double[] { 5, 6, 7, 8 } }))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(AllOrNothing.PossiblyPerfect(["B", "_", "B"], ["B", "D", "C"]));



metrics.Stop();
