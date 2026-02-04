using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TailSwapClassTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TailSwapClass.TailSwap(["a:b", "c:d"]), Is.EqualTo(["a:d", "c:b"]));
            Assert.That(TailSwapClass.TailSwap(["1:2", "3:4"]), Is.EqualTo(["1:4", "3:2"]));
            Assert.That(TailSwapClass.TailSwap(["abc:123", "cde:456"]), Is.EqualTo(["abc:456", "cde:123"]));
            Assert.That(TailSwapClass.TailSwap(["a:12345", "777:xyz"]), Is.EqualTo(["a:xyz", "777:12345"]));
            Assert.That(TailSwapClass.TailSwap(["(:)", "[:]"]), Is.EqualTo(["(:]", "[:)"]));
            Assert.That(TailSwapClass.TailSwap([",:;", ",:,"]), Is.EqualTo([",:,", ",:;"]));
        }
    }
}
