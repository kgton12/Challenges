using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GrasshopperTerminalGameMoveFunctionTest
{
    [Test]
    public void Test1()
    {
        Assert.That(GrasshopperTerminalGameMoveFunction.Move(0, 4), Is.EqualTo(8));
    }
}
