using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheRemainderTest
{
    [Test, Description("Your solution should handle arguments and math as defined in specifications")]
    public void FixedTest()
    {
        Assert.That(FindTheRemainder.Remainder(17, 5), Is.EqualTo(2), "Returned value should be the value left over after dividing as much as possible.");
        Assert.That(FindTheRemainder.Remainder(72, 13), Is.EqualTo(FindTheRemainder.Remainder(13, 72)), "The order the arguments are passed should not matter.");
        Assert.Throws<DivideByZeroException>(() => FindTheRemainder.Remainder(0, 1));
        Assert.Throws<DivideByZeroException>(() => FindTheRemainder.Remainder(0, 0));
    }
}
