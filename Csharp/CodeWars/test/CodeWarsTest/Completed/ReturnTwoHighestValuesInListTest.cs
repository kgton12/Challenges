using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReturnTwoHighestValuesInListTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest(Array.Empty<int>()), Is.EqualTo(Array.Empty<int>()));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([15]), Is.EqualTo([15]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([15, 20, 20, 17]), Is.EqualTo([20, 17]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([4, 10, 10, 9]), Is.EqualTo([10, 9]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([1, 1, 1]), Is.EqualTo([1]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([4, 1, 2, 3, 5]), Is.EqualTo([5, 4]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([1, 1, 2, 2, 3, 3]), Is.EqualTo([3, 2]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([0, 3, 0, 6, 0, 9]), Is.EqualTo([9, 6]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([0, 0, 0]), Is.EqualTo([0]));
            Assert.That(ReturnTwoHighestValuesInList.TwoHighest([0, 9, 0]), Is.EqualTo([9, 0]));
        }
    }
}
