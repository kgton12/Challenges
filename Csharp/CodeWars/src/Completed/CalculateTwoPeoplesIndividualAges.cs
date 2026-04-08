namespace CodeWars.Completed;

public class CalculateTwoPeoplesIndividualAges
{
    public static double[]? GetAges(int sum, int difference)
    {
        if (sum < 0 || difference < 0 || sum < difference) return null;

        double greatAge = (sum + difference) / 2.0;
        double minorAge = (sum - difference) / 2.0;

        return [greatAge, minorAge];
    }
}
