using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StringBasicsTest
{
    [Test]
    [TestCase("uid12345", ExpectedResult = new string[1] { "12345" })]
    [TestCase("   uidabc  ", ExpectedResult = new string[1] { "abc" })]
    [TestCase("#uidswagger", ExpectedResult = new string[1] { "swagger" })]
    [TestCase("uidone, uidtwo", ExpectedResult = new string[2] { "one", "two" })]
    [TestCase("uidCAPSLOCK", ExpectedResult = new string[1] { "capslock" })]
    public string[] BasicTest(string s)
    {
        return StringBasics.GetUserIds(s);
    }
}
