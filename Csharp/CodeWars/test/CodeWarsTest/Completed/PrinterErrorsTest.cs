using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PrinterErrorsTest
{
    [Test]
    public static void Test1()
    {
        string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
        Assert.That(PrinterErrors.PrinterError(s), Is.EqualTo("3/56"));
    }
}
