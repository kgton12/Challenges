using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class VampireNumbersTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(VampireNumbers.VampireTest(21, 6), Is.True, "Basic: 21 * 6 = 126 should return True");
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(VampireNumbers.VampireTest(204, 615), Is.True, "Basic: 204 * 615 = 125460 should return True");
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(VampireNumbers.VampireTest(30, -51), Is.True, "One Negative: 30 * -51 = -1530 should return True");
    }

    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(VampireNumbers.VampireTest(-246, -510), Is.False, "Double Negatives: -246 * -510 = 125460 should return False (The negative signs aren't present on the product)");
    }

    [Test, Order(5)]
    public void Test5()
    {
        Assert.That(VampireNumbers.VampireTest(210, 600), Is.True, "Trailing Zeroes: 210 * 600 = 126000 should return True");
    }

    [Test, Order(6)]
    public void Test6_Symmetric()
    {
        Assert.That(VampireNumbers.VampireTest(6, 21), Is.True, "Symmetry: 6 * 21 = 126 should return True (ordem dos fatores não importa)");
    }

    [Test, Order(8)]
    public void Test8_NonVampireDistinctDigits()
    {
        Assert.That(VampireNumbers.VampireTest(123, 456), Is.False, "Distinct digits mismatch: 123 * 456 = 56088 should return False");
    }

    [Test, Order(9)]
    public void Test9_SmallNonVampire()
    {
        Assert.That(VampireNumbers.VampireTest(2, 5), Is.False, "Small non-vampire: 2 * 5 = 10 should return False");
    }

    [Test, Order(10)]
    public void Test10_RepeatedDigitsMismatch()
    {
        Assert.That(VampireNumbers.VampireTest(11, 11), Is.False, "Repeated digits mismatch: 11 * 11 = 121 should return False");
    }

    [Test, Order(11)]
    public void Test11_OneNegativeReversed()
    {
        Assert.That(VampireNumbers.VampireTest(-30, 51), Is.True, "One Negative reversed: -30 * 51 = -1530 should return True");
    }
}
