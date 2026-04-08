namespace CodeWars.Completed;

public class AddNewItemCollectionsArePassedByReference
{
    public static List<int> AddExtra(List<int> listOfNumbers)
    {
        listOfNumbers.Add(13);
        return listOfNumbers;
    }
}
