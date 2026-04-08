using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StringTemplatesBugFixing5Test
{
    [Test]
    public static void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringTemplatesBugFixing5.BuildString(["Cheese", "Milk", "Chocolate"]), Is.EqualTo("I like Cheese, Milk, Chocolate!"));
            Assert.That(StringTemplatesBugFixing5.BuildString(["Cheese", "Milk"]), Is.EqualTo("I like Cheese, Milk!"));
            Assert.That(StringTemplatesBugFixing5.BuildString(["Chocolate"]), Is.EqualTo("I like Chocolate!"));
        }
    }
}
