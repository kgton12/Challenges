using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortedYesNoHowTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortedYesNoHow.IsSortedAndHow([1, 2]), Is.EqualTo("yes, ascending"));
            Assert.That(SortedYesNoHow.IsSortedAndHow([15, 7, 3, -8]), Is.EqualTo("yes, descending"));
            Assert.That(SortedYesNoHow.IsSortedAndHow([4, 2, 30]), Is.EqualTo("no"));
        }
    }
}
