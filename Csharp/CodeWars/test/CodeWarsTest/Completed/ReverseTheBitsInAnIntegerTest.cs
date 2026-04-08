using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReverseTheBitsInAnIntegerTest
{
    [Test(Description = "Sample tests")]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(417), Is.EqualTo(267));
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(267), Is.EqualTo(417));
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(0), Is.Zero);
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(2017), Is.EqualTo(1087));
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(1023), Is.EqualTo(1023));
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(1024), Is.EqualTo(1));
            Assert.That(ReverseTheBitsInAnInteger.ReverseBits(long.MaxValue), Is.EqualTo(long.MaxValue));
        }
    }
}
