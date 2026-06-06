using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertIntegerToBinaryTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConvertIntegerToBinary.ToBinary(0), Is.EqualTo("0"));
            Assert.That(ConvertIntegerToBinary.ToBinary(2), Is.EqualTo("10"));
            Assert.That(ConvertIntegerToBinary.ToBinary(3), Is.EqualTo("11"));
            Assert.That(ConvertIntegerToBinary.ToBinary(4), Is.EqualTo("100"));
            Assert.That(ConvertIntegerToBinary.ToBinary(5), Is.EqualTo("101"));
        }
    }

    [Test]
    public static void Negative_Numbers_Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConvertIntegerToBinary.ToBinary(-3), Is.EqualTo("11111111111111111111111111111101"));
            Assert.That(ConvertIntegerToBinary.ToBinary(-2066410621), Is.EqualTo("10000100110101010001001110000011"));
        }
    }
}
