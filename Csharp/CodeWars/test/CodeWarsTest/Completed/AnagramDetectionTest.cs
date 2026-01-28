using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AnagramDetectionTest
{
    private static void DoTest(String a, String b, bool expected)
    {
        String message = String.Format("\na = \"{0}\"\nb = \"{1}\"\n", a, b);
        bool actual = AnagramDetection.IsAnagram(a, b);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    public void SampleTests()
    {
        DoTest("", "", true);
        DoTest("aa", "aab", false);
        DoTest("ac", "bb", false);
        DoTest("abab", "cdcd", false);
        DoTest("aab", "bba", false);
        DoTest("foefet", "toffee", true);
        DoTest("Buckethead", "DeathCubeK", true);
        DoTest("Twoo", "Woot", true);
        DoTest("dumble", "bumble", false);
        DoTest("ound", "round", false);
        DoTest("apple", "pale", false);
    }
}
