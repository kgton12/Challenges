using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumAListButIgnoreAnyDuplicatesTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumAListButIgnoreAnyDuplicates.SumNoDuplicates([1, 1, 2, 3]), Is.EqualTo(5));
            Assert.That(SumAListButIgnoreAnyDuplicates.SumNoDuplicates([1, 1, 2, 2, 3]), Is.EqualTo(3));
        }
    }
}
