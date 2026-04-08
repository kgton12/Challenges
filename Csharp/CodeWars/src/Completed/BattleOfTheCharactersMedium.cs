namespace CodeWars.Completed;

public class BattleOfTheCharactersMedium
{
    public static string Battle(string x, string y)
    {
        double sumX = CalculatePositionSum(x);
        double sumY = CalculatePositionSum(y);

        return sumX > sumY ? x
          : sumY > sumX ? y
          : "Tie!";
    }
    public static double CalculatePositionSum(string str) =>
        str.Sum(x => char.IsLower(x) ? (x + 1 - 'a') * 0.5 : x + 1 - 'A');
}
