namespace CodeWars.Completed;

public class ListFiltering
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) =>
        listOfItems.OfType<int>();
}
