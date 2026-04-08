using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RetrieveArrayValueByIndexWithDefaultTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        int[] range = [.. Enumerable.Range(1, 3)];
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RetrieveArrayValueByIndexWithDefault.Solution(range, 1, -1), Is.EqualTo(2));
            Assert.That(RetrieveArrayValueByIndexWithDefault.Solution(range, -1, -1), Is.EqualTo(3));
            Assert.That(RetrieveArrayValueByIndexWithDefault.Solution(range, -5, -1), Is.EqualTo(-1));
            Assert.That(RetrieveArrayValueByIndexWithDefault.Solution(range, -3, -1), Is.EqualTo(1));
        }
    }
}
