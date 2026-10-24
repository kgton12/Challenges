using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class StringSubpatternRecognitionITest
{
    [Test]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("a"), Is.False);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("aaaa"), Is.True);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("abcd"), Is.False);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("abababab"), Is.True);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("ababababa"), Is.False);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("123a123a123a"), Is.True);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("123A123a123a"), Is.False);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("abbaabbaabba"), Is.True);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("abbabbabba"), Is.False);
            Assert.That(StringSubpatternRecognitionI.HasSubpattern("abcdabcabcd"), Is.False);
        }
    }
}
