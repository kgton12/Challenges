using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AlanPartridgeIPartridgeWatchTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(AlanPartridgeIPartridgeWatch.Part(new string[] { "Grouse", "Partridge", "Pheasant" }), Is.EqualTo("Mine's a Pint!"));
        Assert.That(AlanPartridgeIPartridgeWatch.Part(new string[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }), Is.EqualTo("Mine's a Pint!!!!!!!!"));
        Assert.That(AlanPartridgeIPartridgeWatch.Part(new string[] { "Pheasant", "Goose", "Starling", "Robin" }), Is.EqualTo("Lynn, I've pierced my foot on a spike!!"));
    }
}
