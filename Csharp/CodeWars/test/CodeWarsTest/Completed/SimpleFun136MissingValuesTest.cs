using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleFun136MissingValuesTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun136MissingValues.MissingValues([1, 1, 1, 2, 2, 3]), Is.EqualTo(18));
            Assert.That(SimpleFun136MissingValues.MissingValues([96, 56, 24, 46, 75, 46, 75, 21, 46, 21, 75, 96, 56, 96, 56]), Is.EqualTo(12096));
            Assert.That(SimpleFun136MissingValues.MissingValues([27, 65, 44, 39, 44, 21, 21, 44, 65, 39, 21, 65]), Is.EqualTo(28431));
            Assert.That(SimpleFun136MissingValues.MissingValues([66, 4, 80, 66, 4, 83, 97, 81, 19, 4, 80, 51, 83, 81, 83, 66, 51, 80, 97, 81, 97]), Is.EqualTo(18411));
            Assert.That(SimpleFun136MissingValues.MissingValues([60, 76, 86, 76, 86, 53, 60, 88, 71, 71, 71, 86, 88, 76, 88, 17, 60, 26, 17, 17, 26, 53, 98, 53]), Is.EqualTo(249704));
            Assert.That(SimpleFun136MissingValues.MissingValues([42, 23, 45, 33, 33, 19, 42, 79, 79, 23, 95, 95, 79, 19, 42, 33, 19, 23]), Is.EqualTo(192375));
            Assert.That(SimpleFun136MissingValues.MissingValues([4, 74, 41, 41, 41, 88, 63, 35, 35, 4, 88, 13, 63, 74, 63, 88, 4, 74]), Is.EqualTo(5915));
        }
    }
}
