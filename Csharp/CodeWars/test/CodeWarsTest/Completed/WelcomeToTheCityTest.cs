using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WelcomeToTheCityTest
{
    [Test]
    public void SampleTest()
    {
        string expected = "Hello, John Smith! Welcome to Phoenix, Arizona!";
        Assert.That(WelcomeToTheCity.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"), Is.EqualTo(expected));
    }
}
