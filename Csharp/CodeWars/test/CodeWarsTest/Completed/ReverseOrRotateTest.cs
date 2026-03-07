using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReverseOrRotateTest
{
    private static void Testing(string actual, string expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void Test1()
    {
        Testing(ReverseOrRotate.RevRot("1234", 0), "");
        Testing(ReverseOrRotate.RevRot("", 0), "");
        Testing(ReverseOrRotate.RevRot("1234", 5), "");
        string s = "733049910872815764";
        Testing(ReverseOrRotate.RevRot(s, 5), "330479108928157");
    }
}