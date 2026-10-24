using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertAStringToAnArrayTest
{
    [Test]
    public void _1_Example()
    {
        Assert.That(ConvertAStringToAnArray.StringToArray("Robin Singh"), Is.EqualTo(["Robin", "Singh"]));
    }

    [Test]
    public void _2_Example()
    {
        Assert.That(ConvertAStringToAnArray.StringToArray("I love arrays they are my favorite"), Is.EqualTo(["I", "love", "arrays", "they", "are", "my", "favorite"]));
    }
}
