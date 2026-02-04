using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class NumberPairsTest
{
    [TestCase]
    public void getLargerNumber()
    {
        int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
        int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
        Assert.That(NumberPairs.GetLargerNumbers(arr1, arr2), Is.EqualTo(new int[] { 23, 64, 53, 17, 88 }));
    }
}
