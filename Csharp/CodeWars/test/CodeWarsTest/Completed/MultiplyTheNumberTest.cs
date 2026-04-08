using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MultiplyTheNumberTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MultiplyTheNumber.Multiply(10), Is.EqualTo(250));
            Assert.That(MultiplyTheNumber.Multiply(5), Is.EqualTo(25));
            Assert.That(MultiplyTheNumber.Multiply(200), Is.EqualTo(25000));
            Assert.That(MultiplyTheNumber.Multiply(0), Is.Zero);
            Assert.That(MultiplyTheNumber.Multiply(-2), Is.EqualTo(-10));
        }
    }
}
