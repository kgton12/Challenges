using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CamelCaseMethodTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That("test case".CamelCase(), Is.EqualTo("TestCase"));
            Assert.That("camel case method".CamelCase(), Is.EqualTo("CamelCaseMethod"));
            Assert.That("say hello".CamelCase(), Is.EqualTo("SayHello"));
            Assert.That(" camel case word".CamelCase(), Is.EqualTo("CamelCaseWord"));
            Assert.That("".CamelCase(), Is.EqualTo(""));
        }
    }
}
