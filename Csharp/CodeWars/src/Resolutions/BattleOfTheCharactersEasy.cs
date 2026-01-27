namespace CodeWars.Resolutions;

public class BattleOfTheCharactersEasy
{
    public static string Battle(string x, string y)
    {
        int sumX = CalculatePositionSum(x);
        int sumY = CalculatePositionSum(y);

        return sumX > sumY ? x
          : sumY > sumX ? y
          : "Tie!";
    }

    private static int CalculatePositionSum(string str) =>
        str.ToLower().Sum(x => x + 1 - 'a');
}
