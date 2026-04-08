using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MobileDisplayKeystrokesTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard(""), Is.Zero);
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("*#"), Is.EqualTo(2));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("123"), Is.EqualTo(3));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("codewars"), Is.EqualTo(26));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("zruf"), Is.EqualTo(16));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("thisisasms"), Is.EqualTo(37));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("longwordwhichdontreallymakessense"), Is.EqualTo(107));
            Assert.That(MobileDisplayKeystrokes.MobileKeyboard("1234567890*#abcdefghijklmnopqrstuvwxyz"), Is.EqualTo(94));
        }
    }
}
