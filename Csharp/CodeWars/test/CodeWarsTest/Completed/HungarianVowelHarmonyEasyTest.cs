using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HungarianVowelHarmonyEasyTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HungarianVowelHarmonyEasy.Dative("ablak"), Is.EqualTo("ablaknak"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("tükör"), Is.EqualTo("tükörnek"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("keret"), Is.EqualTo("keretnek"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("otthon"), Is.EqualTo("otthonnak"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("virág"), Is.EqualTo("virágnak"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("tett"), Is.EqualTo("tettnek"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("rokkant"), Is.EqualTo("rokkantnak"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("rossz"), Is.EqualTo("rossznak"));
            Assert.That(HungarianVowelHarmonyEasy.Dative("gonosz"), Is.EqualTo("gonosznak"));
        }
    }
}
