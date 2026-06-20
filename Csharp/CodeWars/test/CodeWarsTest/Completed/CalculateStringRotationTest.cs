using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CalculateStringRotationTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CalculateStringRotation.ShiftedDiff("eecoff", "coffee"), Is.EqualTo(4));
            Assert.That(CalculateStringRotation.ShiftedDiff("Moose", "moose"), Is.EqualTo(-1));
            Assert.That(CalculateStringRotation.ShiftedDiff("isn't", "'tisn"), Is.EqualTo(2));
            Assert.That(CalculateStringRotation.ShiftedDiff("Esham", "Esham"), Is.Zero);
            Assert.That(CalculateStringRotation.ShiftedDiff(" ", " "), Is.Zero);
            Assert.That(CalculateStringRotation.ShiftedDiff("hoop", "pooh"), Is.EqualTo(-1));
            Assert.That(CalculateStringRotation.ShiftedDiff("  ", " "), Is.EqualTo(-1));
        }
    }
}
