using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Plus1ArrayTest
{
    [Test, Order(1)]
    public void Test1()
    {
        int[] num = [2, 3, 9];
        int[] newNum = [2, 4, 0];
        Assert.That(Plus1Array.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] num = [4, 3, 2, 5];
        int[] newNum = [4, 3, 2, 6];
        Assert.That(Plus1Array.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] num = [0, 4, 2];
        int[] newNum = [0, 4, 3];
        Assert.That(Plus1Array.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(4)]
    public void Test4()
    {
        int[] num = [9, 9];
        int[] newNum = [1, 0, 0];
        Assert.That(Plus1Array.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(5)]
    public void UpBigArray()
    {
        int[] num = [9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1];
        int[] newNum = [9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2];
        Assert.That(Plus1Array.UpArray(num), Is.EqualTo(newNum));
    }
}
