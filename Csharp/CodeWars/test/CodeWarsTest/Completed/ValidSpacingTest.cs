using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ValidSpacingTest
{
    [Test(Description = "Sample tests")]
    public void SampleTests()
    {
        Test(true, "Hello world");
        Test(false, " Hello world");
        Test(false, "Hello world ");
        Test(true, "Hello");
        Test(true, "Helloworld");
    }

    private static void Test(bool solution, string input)
    {
        Assert.That(ValidSpacingClass.ValidSpacing(input), Is.EqualTo(solution), $"Incorrect answer for input \"{input}\"");
    }
}
