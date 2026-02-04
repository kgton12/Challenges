using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HowOldWillIBeIn2099Test
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HowOldWillIBeIn2099.CalculateAge(2003, 2020), Is.EqualTo("You are 17 years old."));
            Assert.That(HowOldWillIBeIn2099.CalculateAge(2019, 2020), Is.EqualTo("You are 1 year old."));
            Assert.That(HowOldWillIBeIn2099.CalculateAge(2003, 2003), Is.EqualTo("You were born this very year!"));
            Assert.That(HowOldWillIBeIn2099.CalculateAge(2020, 2003), Is.EqualTo("You will be born in 17 years."));
            Assert.That(HowOldWillIBeIn2099.CalculateAge(2020, 2019), Is.EqualTo("You will be born in 1 year."));
        }
    }
}
