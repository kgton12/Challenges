using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StrongNumberSpecialNumbersSeries2Test
{
    [TestCase(1, "STRONG!!!!")]
    [TestCase(2, "STRONG!!!!")]
    [TestCase(145, "STRONG!!!!")]
    [TestCase(7, "Not Strong !!")]
    [TestCase(93, "Not Strong !!")]
    [TestCase(185, "Not Strong !!")]
    public void BasicTests(int input, string expected)
    {
        Assert.That(StrongNumberSpecialNumbersSeries2.StrongNumber(input), Is.EqualTo(expected));
    }
}
