namespace CodeWars.Completed;

public class PriceOfMangoes
{
    public static int Mango(int quantity, int price) =>
        Convert.ToInt32((quantity - Math.Floor(quantity / 3.0)) * price);
}
