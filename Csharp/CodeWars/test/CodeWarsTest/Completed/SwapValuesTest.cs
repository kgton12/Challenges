using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SwapValuesTest
{
    [Test]
    public void ExampleTest()
    {
        int[] args = [1, 2];

        Swapper swapper = new([.. args.Cast<object>()]);
        swapper.SwapValues();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(swapper.Arguments[0], Is.EqualTo(2), "Failed swapping numbers");
            Assert.That(swapper.Arguments[1], Is.EqualTo(1), "Failed swapping numbers");
        }
    }
}
