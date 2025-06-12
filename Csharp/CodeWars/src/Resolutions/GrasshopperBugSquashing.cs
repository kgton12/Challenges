namespace CodeWars.src;

public class GrasshopperBugSquashing
{
    public static int Health = 100;
    public static int Position = 0;
    public static int Coins = 0;
    public static readonly List<string> Log = [];

    public static void PlayTurn()
    {
        RolDice();
        Move();
        Combat();
        GetCoins();
        BuyHealth();
        PrintStatus();
    }
    private static void GetCoins() => Log.Add("GetCoins");
    private static void Move() => Log.Add("Move");
    private static void PrintStatus() => Log.Add("PrintStatus");
    private static void Combat() => Log.Add("Combat");
    private static void RolDice() => Log.Add("RollDice");
    private static void BuyHealth() => Log.Add("BuyHealth");
}
