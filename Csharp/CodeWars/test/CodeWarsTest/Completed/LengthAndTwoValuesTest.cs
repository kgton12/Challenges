using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LengthAndTwoValuesTest
{
    [Test]
    public void SampleTests()
    {
        Assertion([true, false, true, false, true], (5, true, false));
        Assertion(["blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red"], (20, "blue", "red"));
        Assertion([], (0, "lemons", "apples"));
    }

    private void Assertion(object[] expected, (int, object, object) inputs)
    {
        object[] actual = LengthAndTwoValues.Alternate(inputs.Item1, inputs.Item2, inputs.Item3);
        Assert.That(actual, Is.EqualTo(expected),
          $"\n  n = {inputs.Item1}" +
          $"\n  firstValue = {inputs.Item2}" +
          $"\n  secondValue = {inputs.Item3}\n" +
          $"\n  Expected = [{string.Join(", ", expected)}]" +
          $"\n  Actual = [{string.Join(", ", actual)}]\n"
        );
    }
}
