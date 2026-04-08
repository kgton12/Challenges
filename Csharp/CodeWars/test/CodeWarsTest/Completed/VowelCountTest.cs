using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class VowelCountTest
{
    [Test]
    public void TestCase1()
    {
        Assert.That(VowelCount.GetVowelCount("abracadabra"), Is.EqualTo(5), "Incorrect answer for str = \"abracadabra\"");
    }
}
