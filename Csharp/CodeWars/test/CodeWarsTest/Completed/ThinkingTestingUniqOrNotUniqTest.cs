using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ThinkingTestingUniqOrNotUniqTest
{
    [Test]
    public void TestCase()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ThinkingTestingUniqOrNotUniq.Testit([0], [1]), Is.EqualTo([0, 1]));
            Assert.That(ThinkingTestingUniqOrNotUniq.Testit([1, 2], [3, 4]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(ThinkingTestingUniqOrNotUniq.Testit([1], [2, 3, 4]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(ThinkingTestingUniqOrNotUniq.Testit([1, 2, 3], [4]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(ThinkingTestingUniqOrNotUniq.Testit([1, 2], [1, 2]), Is.EqualTo([1, 1, 2, 2]));
        }
    }
}
