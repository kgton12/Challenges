using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WeirdStringCaseTest
{
    private static void DoTest(string input, string expected)
    {
        string actual = WeirdStringCase.ToWeirdCase(input);
        Assert.That(actual, Is.EqualTo(expected), "for input: \"" + input + "\"\n");
    }

    [Test]
    public static void ShouldWorkForSomeExamples()
    {
        DoTest("This", "ThIs");
        DoTest("is", "Is");
        DoTest("This is a test", "ThIs Is A TeSt");
    }
}
