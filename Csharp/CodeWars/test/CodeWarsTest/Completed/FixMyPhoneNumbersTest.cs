using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FixMyPhoneNumbersTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FixMyPhoneNumbers.IsItANum("S:)0207ERGQREG88349F82!efRF)"), Is.EqualTo("02078834982"));
            Assert.That(FixMyPhoneNumbers.IsItANum("sjfniebienvr12312312312ehfWh"), Is.EqualTo("Not a phone number"));
            Assert.That(FixMyPhoneNumbers.IsItANum("0192387415456"), Is.EqualTo("Not a phone number"));
            Assert.That(FixMyPhoneNumbers.IsItANum("v   uf  f 0tt2eg qe0b 8rtyq4eyq564()(((((165"), Is.EqualTo("02084564165"));
            Assert.That(FixMyPhoneNumbers.IsItANum("stop calling me no I have never been in an accident"), Is.EqualTo("Not a phone number"));
        }
    }
}
