using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PrintingArrayElementsWithCommaDelimitersTest
{
    [Test]
    public void BasicTests()
    {
        var data = new object[] { 2, 4, 5, 2 };
        Assert.That(PrintingArrayElementsWithCommaDelimiters.PrintArray(data), Is.EqualTo("2,4,5,2"), "int test failed");
    }
}
