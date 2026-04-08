using CodeWars.Completed;
using static CodeWars.Completed.Getnames;

namespace CodeWarsTest.Completed;

public class GetnamesTest
{
    private static readonly Person[] testCase =
       [
          new("Joe", 20),
          new("Bill", 30),
          new("Kate", 23)
       ];

    [Test, Description("Sample Test")]
    public void Test()
    {
        Assert.That(Getnames.GetNames(testCase), Is.EqualTo(["Joe", "Bill", "Kate"]));
    }
}
