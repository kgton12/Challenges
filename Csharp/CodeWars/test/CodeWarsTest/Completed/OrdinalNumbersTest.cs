using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class OrdinalNumbersTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(OrdinalNumbers.Ordinal(1), Is.EqualTo("st"));
            Assert.That(OrdinalNumbers.Ordinal(11), Is.EqualTo("th"));
            Assert.That(OrdinalNumbers.Ordinal(111), Is.EqualTo("th"));
            Assert.That(OrdinalNumbers.Ordinal(121), Is.EqualTo("st"));
            Assert.That(OrdinalNumbers.Ordinal(20), Is.EqualTo("th"));
            Assert.That(OrdinalNumbers.Ordinal(52), Is.EqualTo("nd"));
            Assert.That(OrdinalNumbers.Ordinal(903, true), Is.EqualTo("d"));
        }
    }

    [Test]
    public void BriefTests()
    {
        Test(0, "th", true);
        Test(0, "th", false);
        Test(1, "st", true);
        Test(1, "st", false);
        Test(2, "d", true);
        Test(2, "nd", false);
        Test(3, "d", true);
        Test(3, "rd", false);
    }

    [Test]
    public void ExtendedTests()
    {
        Test(11, "th", false);
        Test(12, "th", false);
        Test(13, "th", false);
        Test(21, "st", false);
        Test(22, "nd", false);
        Test(33, "d", true);
        Test(111, "th", false);
        Test(1008, "th", false);
        Test(3861, "st", false);
    }
    private static void Test(int number, string expectedOrdinal, bool brief)
    {
        Assert.That(OrdinalNumbers.Ordinal(number, brief), Is.EqualTo(expectedOrdinal));
    }
}
