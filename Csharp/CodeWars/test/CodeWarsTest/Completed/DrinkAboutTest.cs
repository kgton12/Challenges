using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DrinkAboutTest
{
    [TestCase(22, ExpectedResult = "drink whisky")]
    public static string FixedTest(int old)
    {
        return DrinkAbout.PeopleWithAgeDrink(old);
    }
}
