using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AddNewItemCollectionsArePassedByReferenceTest
{
    [Test]
    public void FirstTest()
    {
        List<int> listOfNumbers = [1, 2, 2, 2, 4, 3, 4, 5, 6, 7];
        int expectedCount = listOfNumbers.Count + 1;
        Assert.That(AddNewItemCollectionsArePassedByReference.AddExtra(listOfNumbers), Has.Count.EqualTo(expectedCount));
    }
}
