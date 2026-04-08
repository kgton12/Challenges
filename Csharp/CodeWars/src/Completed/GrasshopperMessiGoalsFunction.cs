namespace CodeWars.Completed;

public class GrasshopperMessiGoalsFunction
{
    public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) =>
        new int[] { laLigaGoals, copaDelReyGoals, championsLeagueGoals }.Sum();
}
