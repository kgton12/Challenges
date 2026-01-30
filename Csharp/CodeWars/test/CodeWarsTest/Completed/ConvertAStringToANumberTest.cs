using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConvertAStringToANumberTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("1234"), Is.EqualTo(1234));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("605"), Is.EqualTo(605));
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("1405"), Is.EqualTo(1405));
    }

    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(ConvertAStringToANumber.StringToNumber("-7"), Is.EqualTo(-7));
    }
}
