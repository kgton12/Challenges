using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CompoundArrayClassTest
{
    [Test]
    public static void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompoundArrayClass.CompoundArray([1, 2, 3, 4, 5, 6], [9, 8, 7, 6]),
                Is.EqualTo([1, 9, 2, 8, 3, 7, 4, 6, 5, 6]));
            Assert.That(CompoundArrayClass.CompoundArray([0, 1, 2], [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]),
                Is.EqualTo([0, 9, 1, 8, 2, 7, 6, 5, 4, 3, 2, 1, 0]));
            Assert.That(CompoundArrayClass.CompoundArray([11, 12], [21, 22, 23, 24]),
                Is.EqualTo([11, 21, 12, 22, 23, 24]));
        }
    }
}