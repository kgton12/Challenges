using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RegexFailureBugFixing2Test
{
    [Test]
    public static void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RegexFailureBugFixing2.FilterWords("You're Bad! timmy!"), Is.EqualTo("You're awesome! timmy!"));
            Assert.That(RegexFailureBugFixing2.FilterWords("You're MEAN! timmy!"), Is.EqualTo("You're awesome! timmy!"));
            Assert.That(RegexFailureBugFixing2.FilterWords("You're UGLY!! timmy!"), Is.EqualTo("You're awesome!! timmy!"));
            Assert.That(RegexFailureBugFixing2.FilterWords("You're horrible! timmy!"), Is.EqualTo("You're awesome! timmy!"));
            Assert.That(RegexFailureBugFixing2.FilterWords("You're HiDeOuS!! timmy!"), Is.EqualTo("You're awesome!! timmy!"));
            Assert.That(RegexFailureBugFixing2.FilterWords("You're Meanish!! timmy!"), Is.EqualTo("You're awesomeish!! timmy!"));
        }
    }
}