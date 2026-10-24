using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheFirstNonconsecutiveNumberTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(FindTheFirstNonconsecutiveNumber.FirstNonConsecutive([1, 2, 3, 4, 6, 7, 8]), Is.EqualTo(6));
    }

    [Test]
    public void SequentialTest()
    {
        Assert.That(FindTheFirstNonconsecutiveNumber.FirstNonConsecutive([1, 2, 3, 4]), Is.Null);
    }
}
