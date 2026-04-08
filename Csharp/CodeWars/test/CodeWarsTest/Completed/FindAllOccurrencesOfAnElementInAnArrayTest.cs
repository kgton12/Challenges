using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindAllOccurrencesOfAnElementInAnArrayTest
{
    [Test, Description("Your solution should pass some fixed tests")]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindAllOccurrencesOfAnElementInAnArray.FindAll([6, 9, 3, 4, 3, 82, 11], 3), Is.EqualTo([2, 4]));
            Assert.That(FindAllOccurrencesOfAnElementInAnArray.FindAll([10, 16, 20, 6, 14, 11, 20, 2, 17, 16, 14], 16), Is.EqualTo([1, 9]));
            Assert.That(FindAllOccurrencesOfAnElementInAnArray.FindAll([20, 20, 10, 13, 15, 2, 7, 2, 20, 3, 18, 2, 3, 2, 16, 10, 9, 9, 7, 5, 15, 5], 20), Is.EqualTo([0, 1, 8]));
        }
    }
}
