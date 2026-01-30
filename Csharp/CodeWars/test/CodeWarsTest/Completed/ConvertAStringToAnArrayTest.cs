using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConvertAStringToAnArrayTest
{
    [Test, Order(1)]
    public void _1_Example()
    {
        Assert.That(ConvertAStringToAnArray.StringToArray("Robin Singh"), Is.EqualTo(["Robin", "Singh"]));
    }

    [Test, Order(2)]
    public void _2_Example()
    {
        Assert.That(ConvertAStringToAnArray.StringToArray("I love arrays they are my favorite"), Is.EqualTo(["I", "love", "arrays", "they", "are", "my", "favorite"]));
    }
}
