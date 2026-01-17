using CodeWars.src.Model;
using CodeWars.src.Resolutions;


Metrics metrics = new();
metrics.Start();

//foreach (var item in AscWeek1Challenge5Medium2.AvgArray(new double[][] { new double[] { 1, 2, 3, 4 }, new double[] { 5, 6, 7, 8 } }))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(ZerobalancedArray.IsZeroBalanced(new List<int> { }));



metrics.Stop();
