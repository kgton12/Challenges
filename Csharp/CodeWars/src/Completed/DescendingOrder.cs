namespace CodeWars.Completed;

public class DescendingOrderClass
{
    public static int DescendingOrder(int num) =>
        int.Parse(
            string.Concat(
                num.ToString()
                .OrderByDescending(char.GetNumericValue)
            )
        );
}
