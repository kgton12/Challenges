using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GapInPrimesTest
{
    [Test, Order(1)]
    public static void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GapInPrimes.Gap(2, 100, 110), Is.EqualTo(new long[] { 101, 103 }));
            Assert.That(GapInPrimes.Gap(4, 100, 110), Is.EqualTo(new long[] { 103, 107 }));
            Assert.That(GapInPrimes.Gap(2, 100, 103), Is.EqualTo(new long[] { 101, 103 }));
            Assert.That(GapInPrimes.Gap(6, 100, 110), Is.Null);
            Assert.That(GapInPrimes.Gap(8, 300, 400), Is.EqualTo(new long[] { 359, 367 }));
            Assert.That(GapInPrimes.Gap(10, 300, 400), Is.EqualTo(new long[] { 337, 347 }));
        }
    }
}
