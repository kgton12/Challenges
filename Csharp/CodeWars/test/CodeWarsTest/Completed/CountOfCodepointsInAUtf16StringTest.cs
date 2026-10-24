using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CountOfCodepointsInAUtf16StringTest
{
    private static void DoTest(String str, int expected)
    {
        int actual = CountOfCodepointsInAUtf16String.GetRealLength(str);
        Assert.That(actual, Is.EqualTo(expected), $"for string: \"{str}\"");
    }

    [Test]
    public void SampleTests()
    {
        DoTest("", 0);
        DoTest("abcd", 4);
        DoTest("中国", 2);
        DoTest("𝓪𝓫𝓬𝓭", 4);
        DoTest("𨭎𩷶", 2);
        DoTest("é", 2);
        DoTest("😸🦌🚀", 3);
        DoTest("↓→↑←", 4);
        DoTest("\nabc\ndef\n", 9);
    }
}
