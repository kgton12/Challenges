using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TheOfficeIiBoredomScoreTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TheOfficeIIBoredomScore.Boredom(new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } }), Is.EqualTo("kill me now"));
            Assert.That(TheOfficeIIBoredomScore.Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }), Is.EqualTo("i can handle this"));
            Assert.That(TheOfficeIIBoredomScore.Boredom(new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } }), Is.EqualTo("party time!!"));
        }
    }
}
