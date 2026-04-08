using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindArrayClassTest
{
    [Test, Description("Basic tests"), Order(1)]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindArrayClass.FindArray(['a', 'a', 'a', 'a', 'a'], [2, 4]), Is.EqualTo(['a', 'a']));
            Assert.That(FindArrayClass.FindArray([0, 1, 5, 2, 1, 8, 9, 1, 5], [1, 4, 7]), Is.EqualTo([1, 1, 1]));
            Assert.That(FindArrayClass.FindArray([1, 2, 3, 4, 5], [0]), Is.EqualTo([1]));
            Assert.That(FindArrayClass.FindArray(["this", "is", "test"], [0, 1, 2]), Is.EqualTo(["this", "is", "test"]));
        }
    }

    [Test, Description("Less basic tests"), Order(2)]
    public void EdgeTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindArrayClass.FindArray([1, 2, 3, 4, 5], [4, 2, 0]), Is.EqualTo([5, 3, 1]), "Should handle unordered indices");
            Assert.That(FindArrayClass.FindArray([1, 2, 3, 4, 5], [2, 2, 2]), Is.EqualTo([3, 3, 3]), "Should handle repeated indices");
            Assert.That(FindArrayClass.FindArray([1, 2, 3, 4, 5], []), Is.EqualTo(Array.Empty<int>()), "Should return empty array if no indices");
            Assert.That(FindArrayClass.FindArray([], [0, 1, 2]), Is.EqualTo(Array.Empty<int>()), "Should return empty array if arr1 is empty");
            Assert.That(FindArrayClass.FindArray([], []), Is.EqualTo(Array.Empty<int>()));
        }
    }
}
