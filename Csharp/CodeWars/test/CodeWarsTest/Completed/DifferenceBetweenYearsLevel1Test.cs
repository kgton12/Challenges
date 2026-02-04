using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DifferenceBetweenYearsLevel1Test
{
    [Test]
    public void SampleTest()
    {
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("1997/10/10", "2015/10/10"), Is.EqualTo(18));
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("1990/10/10", "2015/10/10"), Is.EqualTo(25));
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("2015/10/10", "1990/10/10"), Is.EqualTo(25));
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("1992/10/24", "2015/10/24"), Is.EqualTo(23));
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("2018/10/10", "2000/10/10"), Is.EqualTo(18));
        Assert.That(DifferenceBetweenYearsLevel1.HowManyYears("2000/10/10", "2000/10/10"), Is.Zero);
    }
}
