using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReversedWordsTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReversedWords.ReverseWords("hello world!"), Is.EqualTo("world! hello"));
            Assert.That(ReversedWords.ReverseWords("yoda doesn't speak like this"), Is.EqualTo("this like speak doesn't yoda"));
            Assert.That(ReversedWords.ReverseWords("foobar"), Is.EqualTo("foobar"));
            Assert.That(ReversedWords.ReverseWords("editor kata"), Is.EqualTo("kata editor"));
            Assert.That(ReversedWords.ReverseWords("row row row your boat"), Is.EqualTo("boat your row row row"));
            Assert.That(ReversedWords.ReverseWords(""), Is.EqualTo(""));
        }
    }
}
