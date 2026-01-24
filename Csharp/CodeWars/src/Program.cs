using CodeWars.src.Model;
using CodeWars.src.Resolutions;


Metrics metrics = new();
metrics.Start();

//foreach (var item in StringBasics.GetUserIds("multipleuid"))
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(FindTheCombination.CountCombinations("abeeeeabab", "ab"));

Console.ReadKey();


metrics.Stop();
