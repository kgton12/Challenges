using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CountingDuplicatesTest
{
    [Test, Order(1)]
    public void KataTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CountingDuplicates.DuplicateCount(""), Is.Zero);
            Assert.That(CountingDuplicates.DuplicateCount("abcde"), Is.Zero);
            Assert.That(CountingDuplicates.DuplicateCount("aabbcde"), Is.EqualTo(2));
            Assert.That(CountingDuplicates.DuplicateCount("aabBcde"), Is.EqualTo(2), "should ignore case");
            Assert.That(CountingDuplicates.DuplicateCount("Indivisibility"), Is.EqualTo(1));
            Assert.That(CountingDuplicates.DuplicateCount("Indivisibilities"), Is.EqualTo(2), "characters may not be adjacent");
        }
    }
}
