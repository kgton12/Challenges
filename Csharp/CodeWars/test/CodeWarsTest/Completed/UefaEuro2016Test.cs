using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class UefaEuro2016Test
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(UEFAEURO2016.UefaEuro2016(["Germany", "Ukraine"], [2, 0]), Is.EqualTo("At match Germany - Ukraine, Germany won!"));
            Assert.That(UEFAEURO2016.UefaEuro2016(["Belgium", "Italy"], [0, 2]), Is.EqualTo("At match Belgium - Italy, Italy won!"));
            Assert.That(UEFAEURO2016.UefaEuro2016(["Portugal", "Iceland"], [1, 1]), Is.EqualTo("At match Portugal - Iceland, teams played draw."));
        }
    }
}
