namespace CodeWars.Completed;

public class DetermineOffspringSexBasedOnGenesXXandXYChromosomes
{
    public static string ChromosomeCheck(string sperm)
    {
        return $"Congratulations! You're going to have a {(sperm == "XY" ? "son" : "daughter")}.";
    }
}

