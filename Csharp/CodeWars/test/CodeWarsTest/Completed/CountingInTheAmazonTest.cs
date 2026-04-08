using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CountingInTheAmazonTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CountingInTheAmazon.CountArara(1), Is.EqualTo("anane"));
            Assert.That(CountingInTheAmazon.CountArara(3), Is.EqualTo("adak anane"));
            Assert.That(CountingInTheAmazon.CountArara(8), Is.EqualTo("adak adak adak adak"));
        }
    }
}
