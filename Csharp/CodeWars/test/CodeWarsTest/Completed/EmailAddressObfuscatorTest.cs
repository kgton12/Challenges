using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EmailAddressObfuscatorTest
{
    [Test]
    public void Test1()
    {
        Assert.That(EmailAddressObfuscator.Obfuscate("test@123.com"), Is.EqualTo("test [at] 123 [dot] com"));
    }
    [Test]
    public void Test2()
    {
        Assert.That(EmailAddressObfuscator.Obfuscate("Code_warrior@foo.ac.uk"), Is.EqualTo("Code_warrior [at] foo [dot] ac [dot] uk"));
    }
}
