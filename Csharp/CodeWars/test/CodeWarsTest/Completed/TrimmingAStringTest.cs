using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TrimmingAStringTest
{
    [Test]
    public void ExampleTests()
    {
        DoTest("Creating kata is fun", 14, "Creating ka...");
        DoTest("He", 1, "H...");
        DoTest("Hey", 2, "He...");
        DoTest("Hey", 3, "Hey");
        DoTest("Creating kata is fun", 2, "Cr...");
        DoTest("Code Wars is pretty rad", 3, "Cod...");
        DoTest("Coding rocks", 12, "Coding rocks");
        DoTest("Code Wars is pretty rad", 50, "Code Wars is pretty rad");
        DoTest("London is freezing", 18, "London is freezing");
    }

    private static void DoTest(string phrase, int len, string expected)
    {
        string actual = TrimmingAString.TrimString(phrase, len);
        string msg = $"Incorrect answer for:\n    phrase = \"{phrase}\"\n    len    = {len}";
        Assert.That(actual, Is.EqualTo(expected), msg);
    }
}
