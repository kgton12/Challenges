using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertABooleanToAStringTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConvertABooleanToAString.BooleanToString(true), Is.EqualTo("True"));
            Assert.That(ConvertABooleanToAString.BooleanToString(false), Is.EqualTo("False"));
        }
    }
}
