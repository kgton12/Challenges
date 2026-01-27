namespace CodeWars.Resolutions;

public class DivideAndConquer
{
    public static int DivCon(object[] objArray) => objArray.OfType<int>().Sum() -
               objArray.OfType<string>().Sum(Convert.ToInt32);
}
