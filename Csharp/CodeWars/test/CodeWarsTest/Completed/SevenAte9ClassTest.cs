using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SevenAte9ClassTest
{
    [TestCase("165561786121789797", "16556178612178977")]
    [TestCase("797", "77")]
    [TestCase("7979797", "7777")]
    public void ExampleTests(string input, string expected)
    {
        Assert.That(SevenAte9Class.SevenAteNine(input), Is.EqualTo(expected));
    }
}
