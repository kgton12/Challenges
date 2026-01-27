namespace CodeWars.Resolutions
{
    public class FilterCoffee
    {
        public static string Search(int budget, int[] prices) =>
            string.Join(",", prices.Where(x => x <= budget).OrderBy(x => x));
    }
}
