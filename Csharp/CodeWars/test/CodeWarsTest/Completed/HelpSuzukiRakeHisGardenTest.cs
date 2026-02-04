using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HelpSuzukiRakeHisGardenTest
{
    [Test]
    public void BasicTests()
    {
        var garden1 = "slug spider rock gravel gravel gravel gravel gravel gravel gravel";
        var expectedGarden1 = "gravel gravel rock gravel gravel gravel gravel gravel gravel gravel";
        Assert.That(HelpSuzukiRakeHisGarden.RakeGarden(garden1), Is.EqualTo(expectedGarden1));

        var garden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock slug ant gravel gravel snail rock gravel gravel gravel gravel gravel gravel gravel slug gravel ant gravel gravel gravel gravel rock slug gravel gravel gravel gravel gravel snail gravel gravel rock gravel snail slug gravel gravel spider gravel gravel gravel gravel gravel gravel gravel gravel moss gravel gravel gravel snail gravel gravel gravel ant gravel gravel moss gravel gravel gravel gravel snail gravel gravel gravel gravel slug gravel rock gravel gravel rock gravel gravel gravel gravel snail gravel gravel rock gravel gravel gravel gravel gravel spider gravel rock gravel gravel";
        var expectedGarden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel";
        Assert.That(HelpSuzukiRakeHisGarden.RakeGarden(garden2), Is.EqualTo(expectedGarden2));
    }
}
