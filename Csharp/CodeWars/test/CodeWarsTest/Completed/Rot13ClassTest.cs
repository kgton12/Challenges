using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Rot13ClassTest
{
    [Test, Description("TestTestOne")]
    public void TestTestOne()
    {
        var actualOutput = Rot13Class.Rot13("test");
        Assert.That(actualOutput, Is.EqualTo("grfg"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", actualOutput));
    }

    [Test, Description("TestTestTwo")]
    public void TestTestTwo()
    {
        var actualOutput = Rot13Class.Rot13("Test");
        Assert.That(actualOutput, Is.EqualTo("Grfg"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", actualOutput));
    }
}
