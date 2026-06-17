using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FridayThe13thPart1Test
{
    [Test]
    public void ExampleTest()
    {
        Dictionary<string, int> counselors = new()
        {
        {"Mike", 7},
        {"Alysa", 3}
      };
        Assert.That(FridayThe13thPart1.KillCount(counselors, 7), Is.EqualTo(["Alysa"]));
    }
}
