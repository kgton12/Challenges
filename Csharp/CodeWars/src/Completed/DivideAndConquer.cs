namespace CodeWars.Completed;

public class DivideAndConquer
{
    public static int DivCon(object[] objArray) => objArray.OfType<int>().Sum() -
               objArray.OfType<string>().Sum(Convert.ToInt32);
}
