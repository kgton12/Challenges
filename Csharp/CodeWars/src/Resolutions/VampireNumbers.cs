namespace CodeWars.Resolutions;

public class VampireNumbers
{
    public static bool VampireTest(long x, long y)
    {
        if (x < 0 && y < 0)
            return false;

        string fangs = Math.Abs(x).ToString() + Math.Abs(y).ToString();
        string product = Math.Abs(x * y).ToString();

        if (fangs.Length != product.Length)
            return false;

        string sortedFangs = string.Concat(fangs.OrderBy(c => c));
        string sortedProduct = string.Concat(product.OrderBy(c => c));

        return sortedFangs == sortedProduct;
    }
}