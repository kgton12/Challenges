using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LeonardoDicaprioAndOscarsTest
{
    [Test]
    [TestCase(88, ExpectedResult = "Leo finally won the oscar! Leo is happy")]
    public string LeoTest(int oscar)
    {
        return LeonardoDicaprioAndOscars.Leo(oscar);
    }
}
