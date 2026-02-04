using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SayMePleaseOperationsTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SayMePleaseOperations.SayMeOperations("1 2 3 5 8"), Is.EqualTo("addition, addition, addition"));
            Assert.That(SayMePleaseOperations.SayMeOperations("9 4 5 20 25"), Is.EqualTo("subtraction, multiplication, addition"));
            Assert.That(SayMePleaseOperations.SayMeOperations("10 2 5 -3 -15 12"), Is.EqualTo("division, subtraction, multiplication, subtraction"));
            Assert.That(SayMePleaseOperations.SayMeOperations("2 2 4"), Is.EqualTo("addition"));
        }
    }
}
