using CodeWars.Completed;

namespace CodeWarsTest.Completed
{
    [TestFixture]
    public class ThinkingTestingSomethingCapitalizedTest
    {
        [Test]
        public void TestCase()
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit(""), Is.EqualTo(""));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("a"), Is.EqualTo("A"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("b"), Is.EqualTo("B"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("a a"), Is.EqualTo("A A"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("a b"), Is.EqualTo("A B"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("a b c"), Is.EqualTo("A B C"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("aa"), Is.EqualTo("aA"));
                Assert.That(new ThinkingTestingSomethingCapitalized().Testit("hello world"), Is.EqualTo("hellO worlD"));
            }
        }
    }
}