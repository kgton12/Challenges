using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleMultiplicationTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleMultiplication.Multiply(1), Is.EqualTo(9), "Should return given argument times nine");
            Assert.That(SimpleMultiplication.Multiply(2), Is.EqualTo(16), "Should return given argument times eight");
            Assert.That(SimpleMultiplication.Multiply(8), Is.EqualTo(64), "Should return given argument times eight");
            Assert.That(SimpleMultiplication.Multiply(4), Is.EqualTo(32), "Should return given argument times eight");
            Assert.That(SimpleMultiplication.Multiply(5), Is.EqualTo(45), "Should return given argument times nine");
        }
    }
}
