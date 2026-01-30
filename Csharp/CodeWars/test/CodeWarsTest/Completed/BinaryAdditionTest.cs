using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BinaryAdditionTest
{
    [Test]
    public void TestExample()
    {
        Assert.That(BinaryAddition.AddBinary(1, 2), Is.EqualTo("11"), "Should return \"11\" for 1 + 2");
    }
}
