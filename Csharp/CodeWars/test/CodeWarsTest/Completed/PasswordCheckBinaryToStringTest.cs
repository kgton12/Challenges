using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PasswordCheckBinaryToStringTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        Assert.That(PasswordCheckBinaryToString.DecodePass(new string[] { "password123", "admin", "admin1" },
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"),
            Is.EqualTo("password123"));

        Assert.That(PasswordCheckBinaryToString.DecodePass(new string[] { "password321", "admin", "admin1" },
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"),
            Is.Null);

        Assert.That(PasswordCheckBinaryToString.DecodePass(new string[] { "password456", "pass1", "test12" },
            "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"),
            Is.Null);
    }
}
