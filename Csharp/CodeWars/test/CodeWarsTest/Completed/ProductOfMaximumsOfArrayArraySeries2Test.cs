using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ProductOfMaximumsOfArrayArraySeries2Test
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([4, 3, 5], 2), Is.EqualTo(20));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([10, 8, 7, 9], 3), Is.EqualTo(720));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([8, 6, 4, 6], 3), Is.EqualTo(288));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([10, 2, 3, 8, 1, 10, 4], 5), Is.EqualTo(9600));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([13, 12, -27, -302, 25, 37, 133, 155, -14], 5), Is.EqualTo(247895375));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([-4, -27, -15, -6, -1], 2), Is.EqualTo(4));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([-17, -8, -102, -309], 2), Is.EqualTo(136));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([10, 3, -27, -1], 3), Is.EqualTo(-30));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([14, 29, -28, 39, -16, -48], 4), Is.EqualTo(-253344));
            Assert.That(ProductOfMaximumsOfArrayArraySeries2.MaxProduct([1], 1), Is.EqualTo(1));
        }
    }
}
