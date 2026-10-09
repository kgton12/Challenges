using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class OneDownClassTest
{
    [Test, Order(1)]
    [TestCase("Ifmmp", ExpectedResult = "Hello")]
    [TestCase("Uif usjdl up uijt lbub jt tjnqmf", ExpectedResult = "The trick to this kata is simple")]
    [TestCase("XiBu BcPvU dSbaz UfYu", ExpectedResult = "WhAt AbOuT cRaZy TeXt")]
    [TestCase("BMM DBQT NBZCF", ExpectedResult = "ALL CAPS MAYBE")]
    [TestCase("qVAamFt BsF gVo", ExpectedResult = "pUzZlEs ArE fUn")]
    [TestCase("J ipqf zpv bsf ibwjoh b ojdf ebz", ExpectedResult = "I hope you are having a nice day")]
    public static string SampleTest(string str)
    {
        return OneDownClass.OneDown(str);
    }
}