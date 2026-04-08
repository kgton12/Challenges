using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CategorizeNewMemberTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CategorizeNewMember.OpenOrSenior([[45, 12], [55, 21], [19, 2], [104, 20]]), Is.EqualTo(["Open", "Senior", "Open", "Senior"]));
            Assert.That(CategorizeNewMember.OpenOrSenior([[3, 12], [55, 1], [91, -2], [54, 23]]), Is.EqualTo(["Open", "Open", "Open", "Open"]));
            Assert.That(CategorizeNewMember.OpenOrSenior([[59, 12], [45, 21], [-12, -2], [12, 12]]), Is.EqualTo(["Senior", "Open", "Open", "Open"]));
        }
    }
}
