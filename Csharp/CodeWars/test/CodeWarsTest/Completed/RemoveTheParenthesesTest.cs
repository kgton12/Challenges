using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RemoveTheParenthesesTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveTheParentheses.RemoveParentheses("example(unwanted thing)example"), Is.EqualTo("exampleexample"));
            Assert.That(RemoveTheParentheses.RemoveParentheses("example (unwanted thing) example"), Is.EqualTo("example  example"));
            Assert.That(RemoveTheParentheses.RemoveParentheses("a (bc d)e"), Is.EqualTo("a e"));
            Assert.That(RemoveTheParentheses.RemoveParentheses("a(b(c))"), Is.EqualTo("a"));
            Assert.That(RemoveTheParentheses.RemoveParentheses("hello example (words(more words) here) something"), Is.EqualTo("hello example  something"));
            Assert.That(RemoveTheParentheses.RemoveParentheses("(first group) (second group) (third group)"), Is.EqualTo("  "));
        }
    }
}
