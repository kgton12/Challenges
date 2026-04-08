using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StringsMixTest
{
    [Test]
    public static void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringsMix.Mix("Are they here", "yes, they are here"), Is.EqualTo("2:eeeee/2:yy/=:hh/=:rr"));
            Assert.That(StringsMix.Mix("looping is fun but dangerous", "less dangerous than coding"), Is.EqualTo("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg"));
            Assert.That(StringsMix.Mix(" In many languages", " there's a pair of functions"), Is.EqualTo("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt"));
            Assert.That(StringsMix.Mix("Lords of the Fallen", "gamekult"), Is.EqualTo("1:ee/1:ll/1:oo"));
            Assert.That(StringsMix.Mix("codewars", "codewars"), Is.EqualTo(""));
            Assert.That(StringsMix.Mix("A generation must confront the looming ", "codewarrs"), Is.EqualTo("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr"));
        }
    }
}
