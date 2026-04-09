using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class OperationsWithSetsTest
{
    [Test]
    public void BasicTests()
    {
        var arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var arr2 = new int[] { 2, 4, 6, 8, 10, 12, 14 };
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([4, 8, 5, 3]));

        arr1 = [33, 2, 3, 37, 38, 40, 12, 10, 43, 44, 47, 49, 8, 19, 22, 24, 26, 28, 29, 30];
        arr2 = [1, 34, 17, 7, 9, 10, 43, 49, 22, 27, 28];
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([5, 21, 15, 6]));

        arr1 = [32, 34, 3, 4, 39, 10, 43, 13, 11, 18, 21, 22, 7, 25, 26, 36];
        arr2 = [32, 5, 38, 8, 41, 42, 12, 48, 40, 21, 22, 26, 10, 30];
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([5, 20, 11, 9]));

        arr1 = [0, 33, 37, 6, 10, 44, 13, 47, 16, 18, 22, 25];
        arr2 = [1, 38, 48, 8, 41, 7, 12, 47, 16, 40, 20, 23, 25];
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([3, 19, 9, 10]));

        arr1 = [0, 19, 34, 35, 5, 7, 45, 13, 3, 20, 26, 29, 30];
        arr2 = [33, 4, 38, 1, 8, 13, 47, 23, 28, 30, 31];
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([2, 20, 11, 9]));

        arr1 = [0, 35, 17, 6, 7, 10, 11, 46, 47, 16, 49, 20, 14, 23, 25, 26, 29];
        arr2 = [0, 6, 17, 42, 43, 47, 16, 49, 50, 21, 28, 30];
        Assert.That(OperationsWithSets.Process2Arrays(arr1, arr2), Is.EqualTo([6, 17, 11, 6]));
    }
}