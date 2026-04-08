using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CharacterCounterTest
{
    private static void DoTest(bool expected, String str)
    {
        bool actual = CharacterCounter.ValidateWord(str);
        Assert.That(actual, Is.EqualTo(expected), "for s = \"" + str + "\"");
    }

    [Test]
    public void SampleTests()
    {
        DoTest(true, "a");
        DoTest(true, "aa");
        DoTest(true, "aAbB!!");
        DoTest(true, "");
        DoTest(false, "abcabcab");
        DoTest(false, "abccabcd");
        DoTest(true, "???!!!");
        DoTest(false, "aaaabb");
        DoTest(true, "abcabc");
        DoTest(true, "Abcabc");
        DoTest(true, "abc123");
        DoTest(false, "abcabcd");
        DoTest(true, "abc!abc!");
        DoTest(false, "abc:abc");
    }
}
