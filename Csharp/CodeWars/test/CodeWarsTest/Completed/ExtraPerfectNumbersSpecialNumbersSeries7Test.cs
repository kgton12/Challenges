using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExtraPerfectNumbersSpecialNumbersSeries7Test
{
    [Test]
    public void BasicTests()
    {
        Assert.That(ExtraPerfectNumbersSpecialNumbersSeries7.ExtraPerfect(3), Is.EqualTo(new int[] { 1, 3 }));
        Assert.That(ExtraPerfectNumbersSpecialNumbersSeries7.ExtraPerfect(5), Is.EqualTo(new int[] { 1, 3, 5 }));
        Assert.That(ExtraPerfectNumbersSpecialNumbersSeries7.ExtraPerfect(7), Is.EqualTo(new int[] { 1, 3, 5, 7 }));
        Assert.That(ExtraPerfectNumbersSpecialNumbersSeries7.ExtraPerfect(28), Is.EqualTo(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27 }));
        Assert.That(ExtraPerfectNumbersSpecialNumbersSeries7.ExtraPerfect(39), Is.EqualTo(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 }));
    }
}
