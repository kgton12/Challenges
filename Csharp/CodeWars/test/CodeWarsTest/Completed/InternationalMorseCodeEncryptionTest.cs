using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class InternationalMorseCodeEncryptionTest
{
    static void Test(string morse, string english)
    {
        Assert.That(InternationalMorseCodeEncryption.ToMorse(english), Is.EqualTo(morse));
    }

    [Test, Order(1)]
    public void Test1()
    {
        string english = "HELLO WORLD";
        string morse = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
        Test(morse, english);
    }

    [Test, Order(2)]
    public void Test2()
    {
        string english = "SOS";
        string morse = "... --- ...";
        Test(morse, english);
    }

    [Test, Order(3)]
    public void Test3()
    {
        string english = "1836";
        string morse = ".---- ---.. ...-- -....";
        Test(morse, english);
    }

    [Test, Order(4)]
    public void Test4()
    {
        string english = "THE QUICK BROWN FOX";
        string morse = "- .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-";
        Test(morse, english);
    }

    [Test, Order(5)]
    public void Test5()
    {
        string english = "JUMPED OVER THE";
        string morse = ".--- ..- -- .--. . -..   --- ...- . .-.   - .... .";
        Test(morse, english);
    }
}
