namespace CodeWars.Completed;

public class RemoveAllTheMarkedElementsOfaList
{
    public static int[] Remove(int[] integerList, int[] valuesList) => [.. integerList.Where(x => !valuesList.Contains(x))];
}
