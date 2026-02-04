using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleStringCharactersTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleStringCharacters.Solve("Codewars@codewars123.com"), Is.EqualTo([1, 18, 3, 2]));
            Assert.That(SimpleStringCharacters.Solve("bgA5<1d-tOwUZTS8yQ"), Is.EqualTo([7, 6, 3, 2]));
            Assert.That(SimpleStringCharacters.Solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"), Is.EqualTo([9, 9, 6, 9]));
            Assert.That(SimpleStringCharacters.Solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"), Is.EqualTo([15, 8, 6, 9]));
        }
    }
}
