namespace CodeWars.Resolutions;

public static class GraderClass
{
    public static char Grader(double score)
    {
        return score switch
        {
            >= 1 or <= 0.6 => 'F',
            >= 0.9 => 'A',
            >= 0.8 => 'B',
            >= 0.7 => 'C',
            >= 0.6 => 'D',
            _ => 'F'
        };
    }
}
