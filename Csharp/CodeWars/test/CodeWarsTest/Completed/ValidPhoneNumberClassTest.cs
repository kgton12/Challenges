using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ValidPhoneNumberClassTest
{
    [Test, Order(1)]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ValidPhoneNumberClass.ValidPhoneNumber("(123) 456-7890"), Is.True);
            Assert.That(ValidPhoneNumberClass.ValidPhoneNumber("(1111)5X5 2345"), Is.False);
        }
    }
}
