using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CurryingFunctionsMultiplyAllElementsInAnArrayTest
{
    [Test, Description("must return an array")]
    [Order(1)]
    public void ArrayTest()
    {
        Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([1])(1).GetType().IsArray, Is.True);
    }

    [Test, Description("array has correct length")]
    [Order(2)]
    public void LengthTest()
    {
        Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([1, 2])(1).Length, Is.EqualTo(2));
    }

    [Test, Description("returned array has correct values")]
    [Order(3)]
    public void ValuesTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([1, 2, 3])(1), Is.EqualTo([1, 2, 3]));
            Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([1, 2, 3])(2), Is.EqualTo([2, 4, 6]));
            Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([1, 2, 3])(0), Is.EqualTo([0, 0, 0]));
            Assert.That(CurryingFunctionsMultiplyAllElementsInAnArray.MultiplyAll([])(10), Is.EqualTo(new int[] { }), "should return an empty array");
        }
    }
}
