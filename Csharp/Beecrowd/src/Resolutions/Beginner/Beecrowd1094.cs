namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1094
{
    public static void Experiences()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> experiment = [];

        for (int i = 0; i < n; i++)
        {
            string[] inputValues = (Console.ReadLine() ?? string.Empty).Split(' ');

            if (experiment.ContainsKey(inputValues[1]))
                experiment[inputValues[1]] += Convert.ToInt32(inputValues[0]);
            else
                experiment.Add(inputValues[1], Convert.ToInt32(inputValues[0]));
        }

        int totalExperiments = experiment.Sum(x => x.Value);
        int rabbitsTotal = experiment["C"];
        int ratsTotal = experiment["R"];
        int frogsTotal = experiment["S"];

        double percentageRabbits = totalExperiments > 0 ? (double)rabbitsTotal / totalExperiments * 100 : 0;
        double percentageRats = totalExperiments > 0 ? (double)ratsTotal / totalExperiments * 100 : 0;
        double percentageFrogs = totalExperiments > 0 ? (double)frogsTotal / totalExperiments * 100 : 0;


        Console.WriteLine($"Total: {totalExperiments} cobaias");
        Console.WriteLine($"Total de coelhos: {rabbitsTotal}");
        Console.WriteLine($"Total de ratos: {ratsTotal}");
        Console.WriteLine($"Total de sapos: {frogsTotal}");
        Console.WriteLine($"Percentual de coelhos: {percentageRabbits:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentageRats:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentageFrogs:F2} %");
    }
}
