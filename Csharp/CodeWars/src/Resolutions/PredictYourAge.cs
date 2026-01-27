namespace CodeWars.Resolutions;

public class PredictYourAge
{
    public static int PredictAge(params int[] ages)
    {
        if (ages == null || ages.Length == 0)
            return 0;

        double sumOfSquares = ages.Sum(age => age * age);
        double sqrt = Math.Sqrt(sumOfSquares);

        return (int)(sqrt / 2);
    }
}
