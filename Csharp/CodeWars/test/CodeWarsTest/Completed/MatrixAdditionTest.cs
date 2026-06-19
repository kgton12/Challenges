using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MatrixAdditionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(MatrixAdditionClass.MatrixAddition(
            [
                [1, 2],
                [1, 2]
            ],
            [
                [2, 3],
                [2, 3]
            ]), Is.EqualTo(new int[][] { [3, 5], [3, 5] }));
    }
}