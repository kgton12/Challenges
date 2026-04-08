using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TotalAmountOfPointsTest
{
    //[Test, Order(1)]
    //public void Test1() =>
    //            Test(["1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"], 30);

    //[Test, Order(2)]
    //public void Test2() =>
    //    Test(["1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4"], 10);

    //[Test, Order(3)]
    //public void Test3() =>
    //    Test(["0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4"], 0);

    [Test, Order(4)]
    public void Test4() =>
        Test(["1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4"], 15);

    [Test, Order(5)]
    public void Test5() =>
        Test(["1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4"], 12);

    private static void Test(string[] input, int expectedOutput) =>
        Assert.That(TotalAmountOfPoints.TotalPoints(input), Is.EqualTo(expectedOutput));
}
