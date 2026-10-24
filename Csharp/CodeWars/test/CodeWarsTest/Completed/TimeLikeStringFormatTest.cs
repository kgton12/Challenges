using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class TimeLikeStringFormatTest
{
    [Test, Description("Should format a valid number")]
    public void FormatTest()
    {
        Assert.That(TimeLikeStringFormat.FormatTime(1000), Is.EqualTo("10:00"));
    }

    [Test, Description("Should throw ArgumentException for invalid number")]
    public void ErrorTest()
    {
        Assert.That(() => TimeLikeStringFormat.FormatTime(80), Throws.ArgumentException);
    }
}
