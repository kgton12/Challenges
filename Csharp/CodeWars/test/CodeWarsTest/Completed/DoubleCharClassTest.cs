using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DoubleCharClassTest
{
    [Test]
    [TestCase("abcd", ExpectedResult = "aabbccdd")]
    [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
    [TestCase("1337", ExpectedResult = "11333377")]
    [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
    [TestCase("123456", ExpectedResult = "112233445566")]
    [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
    public static string FixedTest(string s)
    {
        return DoubleCharClass.DoubleChar(s);
    }
}
