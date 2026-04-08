namespace CodeWars.Completed;

public class Katastrophe
{
    public static string StrongEnough(int[][] earthquake, int age)
    {
        int[] sumOfSets = earthquake.Select(x => x.Sum()).ToArray();

        long finalSum = 1;
        foreach (var sum in sumOfSets)
            finalSum *= sum;

        double initialForce = 1000;

        double strength = CalculateDepreciation(initialForce, age);

        return finalSum > strength
            ? "Needs Reinforcement!"
            : "Safe!";
    }

    private static double CalculateDepreciation(double valueInitial, int age) =>
        valueInitial * Math.Pow(0.99, age);
}
