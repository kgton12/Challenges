using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class CleverSplitClassTest
{
    [TestCase("Buy a !car [!red green !white] [cheap or !new]", new string[] { "Buy", "a", "!car", "[!red green !white]", "[cheap or !new]" })]
    [TestCase("!Learning !C# is [a joy]", new string[] { "!Learning", "!C#", "is", "[a joy]" })]
    [TestCase("[Cats and dogs] are !beautiful and [cute]", new string[] { "[Cats and dogs]", "are", "!beautiful", "and", "[cute]" })]
    [TestCase("You", new string[] { "You" })]
    public void FixedTest(string s, string[] expected)
    {
        Assert.That(CleverSplitClass.CleverSplit(s), Is.EqualTo(expected));
    }
}
