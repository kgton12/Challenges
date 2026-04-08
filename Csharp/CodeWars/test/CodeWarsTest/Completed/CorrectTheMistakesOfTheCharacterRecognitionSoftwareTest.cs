using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CorrectTheMistakesOfTheCharacterRecognitionSoftwareTest
{
    [Test]
    public void CorrectTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CorrectTheMistakesOfTheCharacterRecognitionSoftware.Correct("L0ND0N"), Is.EqualTo("LONDON"));
            Assert.That(CorrectTheMistakesOfTheCharacterRecognitionSoftware.Correct("DUBL1N"), Is.EqualTo("DUBLIN"));
            Assert.That(CorrectTheMistakesOfTheCharacterRecognitionSoftware.Correct("51NGAP0RE"), Is.EqualTo("SINGAPORE"));
            Assert.That(CorrectTheMistakesOfTheCharacterRecognitionSoftware.Correct("BUDAPE5T"), Is.EqualTo("BUDAPEST"));
            Assert.That(CorrectTheMistakesOfTheCharacterRecognitionSoftware.Correct("PAR15"), Is.EqualTo("PARIS"));
        }
    }
}
