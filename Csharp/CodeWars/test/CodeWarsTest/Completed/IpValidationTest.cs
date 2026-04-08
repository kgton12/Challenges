using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IpValidationTest
{
    [Test]
    public void TestCasesTrue()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IpValidation.IsValidIp("0.0.0.0"), Is.True);
            Assert.That(IpValidation.IsValidIp("12.255.56.1"), Is.True);
            Assert.That(IpValidation.IsValidIp("137.255.156.100"), Is.True);
        }
    }

    [Test]
    public void TestCasesFalse()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IpValidation.IsValidIp(""), Is.False);
            Assert.That(IpValidation.IsValidIp("abc.def.ghi.jkl"), Is.False);
            Assert.That(IpValidation.IsValidIp("123.456.789.0"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56.00"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56.7.8"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.256.78"), Is.False);
            Assert.That(IpValidation.IsValidIp("1234.34.56"), Is.False);
            Assert.That(IpValidation.IsValidIp("pr12.34.56.78"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56.78sf"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56 .1"), Is.False);
            Assert.That(IpValidation.IsValidIp("12.34.56.-1"), Is.False);
            Assert.That(IpValidation.IsValidIp("123.045.067.089"), Is.False);
        }
    }
}
