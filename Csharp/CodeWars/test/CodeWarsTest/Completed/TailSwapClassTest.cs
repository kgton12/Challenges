using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TailSwapClassTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(TailSwapClass.TailSwap(new[] { "a:b", "c:d" }), Is.EqualTo(new[] { "a:d", "c:b" }));
        Assert.That(TailSwapClass.TailSwap(new[] { "1:2", "3:4" }), Is.EqualTo(new[] { "1:4", "3:2" }));
        Assert.That(TailSwapClass.TailSwap(new[] { "abc:123", "cde:456" }), Is.EqualTo(new[] { "abc:456", "cde:123" }));
        Assert.That(TailSwapClass.TailSwap(new[] { "a:12345", "777:xyz" }), Is.EqualTo(new[] { "a:xyz", "777:12345" }));
        Assert.That(TailSwapClass.TailSwap(new[] { "(:)", "[:]" }), Is.EqualTo(new[] { "(:]", "[:)" }));
        Assert.That(TailSwapClass.TailSwap(new[] { ",:;", ",:," }), Is.EqualTo(new[] { ",:,", ",:;" }));
    }
}
