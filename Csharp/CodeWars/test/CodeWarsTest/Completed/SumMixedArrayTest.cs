using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumMixedArrayTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumMixedArray.SumMix([9, 3, "7", "3"]), Is.EqualTo(22));
            Assert.That(SumMixedArray.SumMix(["5", "0", 9, 3, 2, 1, "9", 6, 7]), Is.EqualTo(42));
            Assert.That(SumMixedArray.SumMix(["3", 6, 6, 0, "5", 8, 5, "6", 2, "0"]), Is.EqualTo(41));
        }
    }
}
