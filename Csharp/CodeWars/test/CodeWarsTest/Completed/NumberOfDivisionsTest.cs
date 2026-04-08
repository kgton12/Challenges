using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NumberOfDivisionsTest
{
    [Test, Description("Sample Tests")]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NumberOfDivisions.Divisions(6, 2), Is.EqualTo(2));
            Assert.That(NumberOfDivisions.Divisions(100, 2), Is.EqualTo(6));
            Assert.That(NumberOfDivisions.Divisions(2450, 5), Is.EqualTo(4));
            Assert.That(NumberOfDivisions.Divisions(9999, 3), Is.EqualTo(8));
            Assert.That(NumberOfDivisions.Divisions(2, 3), Is.Zero);
            Assert.That(NumberOfDivisions.Divisions(5, 5), Is.EqualTo(1));
        }
    }
}
