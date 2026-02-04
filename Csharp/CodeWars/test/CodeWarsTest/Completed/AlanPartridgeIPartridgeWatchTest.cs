using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AlanPartridgeIPartridgeWatchTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AlanPartridgeIPartridgeWatch.Part(["Grouse", "Partridge", "Pheasant"]), Is.EqualTo("Mine's a Pint!"));
            Assert.That(AlanPartridgeIPartridgeWatch.Part(["Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster"]), Is.EqualTo("Mine's a Pint!!!!!!!!"));
            Assert.That(AlanPartridgeIPartridgeWatch.Part(["Pheasant", "Goose", "Starling", "Robin"]), Is.EqualTo("Lynn, I've pierced my foot on a spike!!"));
        }
    }
}
