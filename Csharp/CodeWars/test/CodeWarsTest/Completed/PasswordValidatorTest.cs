using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PasswordValidatorTest
{
    [Test]
    [Description("Valid passwords")]
    public void TestValidPasswords()
    {
        DoTest("Abcd1234", true);
        DoTest("AbcdefGhijKlmnopQRsTuvwxyZ1234567890", true);
        DoTest("Ab1!@#$%^&*()-_+={}[]|:;?/>.<,", true);
        DoTest(" aA1----", true);
        DoTest("4aA1----", true);
    }

    [Test]
    [Description("Too short passwords")]
    public void TestTooShortPasswords()
    {
        DoTest("Abcd123", false);
    }

    [Test]
    [Description("Missing uppercase letters")]
    public void TestMissingUppercaseLetters()
    {
        DoTest("abcd1234", false);
    }

    [Test]
    [Description("Missing digits")]
    public void TestMissingDigits()
    {
        DoTest("abcdABCD", false);
    }

    [Test]
    [Description("Missing lowercase letters")]
    public void TestMissingLowercaseLetters()
    {
        DoTest("ABCD1234", false);
    }

    [Test]
    [Description("Only special characters")]
    public void TestOnlySpecialCharacters()
    {
        DoTest("!@#$%^&*()-_+={}[]|:;?/>.<,", false);
    }

    [Test]
    [Description("Empty password")]
    public void TestEmptyPassword()
    {
        DoTest("", false);
    }

    private static void DoTest(string password, bool expected)
    {
        Assert.That(PasswordValidator.Password(password), Is.EqualTo(expected), $"Expected {expected} for password \"{password}\".");
    }
}
