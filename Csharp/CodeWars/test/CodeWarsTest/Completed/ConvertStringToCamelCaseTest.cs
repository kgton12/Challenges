using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConvertStringToCamelCaseTest
{
    [Test]
    public void KataTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior')");
            Assert.That(ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior')");
        }
    }
}
