using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MonkeysMath01HowManyZerosTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MonkeysMath01HowManyZeros.CountZero(""), Is.Zero, "There are no '0's.");
            Assert.That(MonkeysMath01HowManyZeros.CountZero("0"), Is.EqualTo(1), "There is 1 '0'.");
            Assert.That(MonkeysMath01HowManyZeros.CountZero("()"), Is.EqualTo(1), "There is 1 '0'.");
            Assert.That(MonkeysMath01HowManyZeros.CountZero("O()()"), Is.EqualTo(3), "There are 3 '0's.");
            Assert.That(MonkeysMath01HowManyZeros.CountZero("1234567890"), Is.EqualTo(5), "There are 5 '0's.");
            Assert.That(MonkeysMath01HowManyZeros.CountZero("abcdefghijklmnopqrstuvwxyz"), Is.EqualTo(8), "There are 8 '0's.");
        }
    }
}
