using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SchrodingerSBooleanTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SchrodingerSBoolean.omnibool == true, "Tested expression: Kata.omnibool == true");
            Assert.That(SchrodingerSBoolean.omnibool == false, "Tested expression: Kata.omnibool == false");
        }
    }
}
