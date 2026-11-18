using CodeWars;

namespace CodeWarsTest;

[TestFixture]
public class TheRobberLanguageTest
{
    [Test]
    public void SampleTests()
    {
        Assertion("hohelollolo wowororloldod", "hello world");
        Assertion("cocododinongog isos fofunon", "coding is fun");
        Assertion("fofolollolowow tothohe wowhohitote rorabobbobitot", "follow the white rabbit");
        Assertion("SOS.O.SOS", "S.O.S");
    }
    [Test]
    public void ExtraFixedTests()
    {
        Assertion("", "");
        Assertion("  .  ", "  .  ");
        Assertion("HOHelollolo WOWororloldod!", "Hello World!");
        Assertion("WOWororloldod ofof WOWarorcocrorafoftot", "World of Warcraft");
        Assertion(" <-=wowwowwow.cocododewowarorsos.cocomom=-> ", " <-=www.codewars.com=-> ");
        Assertion("abobcocdodefofgoghohijojkoklolmomnonopopqoqrorsostotuvovwowxoxyoyzoz", "abcdefghijklmnopqrstuvwxyz");
        Assertion("ABOBCOCDODEFOFGOGHOHIJOJKOKLOLMOMNONOPOPQOQRORSOSTOTUVOVWOWXOXYOYZOZ", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    }

    private static void Assertion(string expected, string sentence) =>
      Assert.That(
        TheRobberLanguage.RobberEncode(sentence),
        Is.EqualTo(expected),
        $"Input: \"{sentence}\""
      );
}