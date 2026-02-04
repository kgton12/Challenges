using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class EvensAndOddsClassTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EvensAndOddsClass.EvensAndOdds(2), Is.EqualTo("10"));
            Assert.That(EvensAndOddsClass.EvensAndOdds(13), Is.EqualTo("d"));
            Assert.That(EvensAndOddsClass.EvensAndOdds(47), Is.EqualTo("2f"));
            Assert.That(EvensAndOddsClass.EvensAndOdds(0), Is.EqualTo("0"));
            Assert.That(EvensAndOddsClass.EvensAndOdds(12800), Is.EqualTo("11001000000000"));
        }
    }
}
