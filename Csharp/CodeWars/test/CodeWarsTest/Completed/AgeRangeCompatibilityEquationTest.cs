using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AgeRangeCompatibilityEquationTest
{
    [Test, Description("Example Test Cases")]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AgeRangeCompatibilityEquation.DatingRange(17), Is.EqualTo("15-20"));
            Assert.That(AgeRangeCompatibilityEquation.DatingRange(40), Is.EqualTo("27-66"));
            Assert.That(AgeRangeCompatibilityEquation.DatingRange(15), Is.EqualTo("14-16"));
            Assert.That(AgeRangeCompatibilityEquation.DatingRange(35), Is.EqualTo("24-56"));
            Assert.That(AgeRangeCompatibilityEquation.DatingRange(10), Is.EqualTo("9-11"));
        }
    }
}
