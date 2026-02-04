using CodeWars.Resolutions;

namespace CodeWarsTest;

public class SumAListButIgnoreAnyDuplicatesTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(SumAListButIgnoreAnyDuplicates.SumNoDuplicates(new int[] { 1, 1, 2, 3 }), Is.EqualTo(5));
        Assert.That(SumAListButIgnoreAnyDuplicates.SumNoDuplicates(new int[] { 1, 1, 2, 2, 3 }), Is.EqualTo(3));
    }
}
