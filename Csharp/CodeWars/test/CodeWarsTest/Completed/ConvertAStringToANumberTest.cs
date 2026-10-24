using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertAStringToANumberTest
{
    [Test]
    public void Test1()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("1234"), Is.EqualTo(1234));
    }

    [Test]
    public void Test2()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("605"), Is.EqualTo(605));
    }

    [Test]
    public void Test3()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("1405"), Is.EqualTo(1405));
    }

    [Test]
    public void Test4()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("-7"), Is.EqualTo(-7));
    }
}
