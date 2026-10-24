using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class Basics03StringsNumbersAndCalculationTest
{
    [Test]
    public void Smile67KataTestWithoutRandom1()
    {
        Assert.That(Basics03StringsNumbersAndCalculation.CalculateString(";$%§fsdfsd235??df/sdfgf5gh.000kk0000"), Is.EqualTo("47"));
    }
    [Test]
    public void Smile67KataTestWithoutRandom2()
    {
        Assert.That(Basics03StringsNumbersAndCalculation.CalculateString("sdfsd23454sdf*2342"), Is.EqualTo("54929268"));
    }
    [Test]
    public void Smile67KataTestWithoutRandom3()
    {
        Assert.That(Basics03StringsNumbersAndCalculation.CalculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"), Is.EqualTo("-210908"));
    }
    [Test]
    public void Smile67KataTestWithoutRandom4()
    {
        Assert.That(Basics03StringsNumbersAndCalculation.CalculateString("fsdfsd234.4554s4234df+sf234442"), Is.EqualTo("234676"));
    }
    [Test]
    public void Smile67KataTestWithoutRandom5()
    {
        Assert.That(Basics03StringsNumbersAndCalculation.CalculateString("gdfgdf234dg54gf*23oP42"), Is.EqualTo("54929268"));
    }
}