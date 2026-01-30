using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheFirstNonconsecutiveNumberTest
{
    [Test]
    [Order(1)]
    public void SampleTest()
    {
        Assert.That(FindTheFirstNonconsecutiveNumber.FirstNonConsecutive([1, 2, 3, 4, 6, 7, 8]), Is.EqualTo(6));
    }

    [Test]
    [Order(2)]
    public void SequentialTest()
    {
        Assert.That(FindTheFirstNonconsecutiveNumber.FirstNonConsecutive([1, 2, 3, 4]), Is.Null);
    }
}
