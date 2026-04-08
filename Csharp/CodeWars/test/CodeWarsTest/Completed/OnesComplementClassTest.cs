using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class OnesComplementClassTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(OnesComplementClass.OnesComplement("0"), Is.EqualTo("1"));
            Assert.That(OnesComplementClass.OnesComplement("1"), Is.EqualTo("0"));
            Assert.That(OnesComplementClass.OnesComplement("10"), Is.EqualTo("01"));
            Assert.That(OnesComplementClass.OnesComplement("01"), Is.EqualTo("10"));
            Assert.That(OnesComplementClass.OnesComplement("1101"), Is.EqualTo("0010"));
        }
    }
}
