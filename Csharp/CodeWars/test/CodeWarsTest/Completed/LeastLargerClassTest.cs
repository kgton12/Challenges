using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LeastLargerClassTest
{
    [Test, Description("No Least Larger Exists (=> Return -1)"), Order(1)]
    public void NoLeastLargerExists() =>
            Assert.That(LeastLargerClass.LeastLarger([4, 1, 3, 5, 6], 4), Is.EqualTo(-1), "Incorrect output for Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 4):");

    [Test, Description("Least Larger Exists"), Order(2)]
    public void LeastLargerExists()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LeastLargerClass.LeastLarger([1, 3, 5, 2, 4], 0), Is.EqualTo(3), "Incorrect output for Kata.LeastLarger(new[] { 1, 3, 5, 2, 4 }, 0):");
            Assert.That(LeastLargerClass.LeastLarger([4, 1, 3, 5, 6], 0), Is.EqualTo(3), "Incorrect output for Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 0):");
        }
    }
}
