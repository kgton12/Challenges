using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StringTemplatesBugFixing5Test
{
    [Test]
    public static void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringTemplatesBugFixing5.BuildString(new string[] { "Cheese", "Milk", "Chocolate" }), Is.EqualTo("I like Cheese, Milk, Chocolate!"));
            Assert.That(StringTemplatesBugFixing5.BuildString(new string[] { "Cheese", "Milk" }), Is.EqualTo("I like Cheese, Milk!"));
            Assert.That(StringTemplatesBugFixing5.BuildString(new string[] { "Chocolate" }), Is.EqualTo("I like Chocolate!"));
        }
    }
}
