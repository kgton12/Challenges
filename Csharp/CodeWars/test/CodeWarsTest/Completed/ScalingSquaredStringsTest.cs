using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ScalingSquaredStringsTest
{
    private static void Testing(string actual, string expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Description("Fixed Tests scale")]
    public static void Test1()
    {
        String a = "abcd\nefgh\nijkl\nmnop";
        String r = "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\n"
                + "iijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp";
        Testing(ScalingSquaredStrings.Scale(a, 2, 3), r);
        Testing(ScalingSquaredStrings.Scale("", 5, 5), "");
        Testing(ScalingSquaredStrings.Scale("Kj\nSH", 1, 2), "Kj\nKj\nSH\nSH");
    }
}
