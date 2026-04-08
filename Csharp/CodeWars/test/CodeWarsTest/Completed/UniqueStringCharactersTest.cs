using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class UniqueStringCharactersTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(UniqueStringCharacters.Solve("xyab", "xzca"), Is.EqualTo("ybzc"));
            Assert.That(UniqueStringCharacters.Solve("xyabb", "xzca"), Is.EqualTo("ybbzc"));
            Assert.That(UniqueStringCharacters.Solve("abcd", "xyz"), Is.EqualTo("abcdxyz"));
            Assert.That(UniqueStringCharacters.Solve("xxx", "xzca"), Is.EqualTo("zca"));
        }
    }
}
