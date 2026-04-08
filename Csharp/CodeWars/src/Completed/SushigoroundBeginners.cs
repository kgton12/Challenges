namespace CodeWars.Completed;

public class SushigoroundBeginners
{
    public static int TotalBill(string str)
    {
        int amountOfSushiConsumed = str.Where(x => x.Equals('r')).Count();

        return (amountOfSushiConsumed - (amountOfSushiConsumed / 5)) * 2;
    }
}
