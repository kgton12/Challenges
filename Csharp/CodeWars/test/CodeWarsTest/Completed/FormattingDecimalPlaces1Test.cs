using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FormattingDecimalPlaces1Test
{
    [Test, Order(1)]
    public void Test_01()
    {
        Assert.That(FormattingDecimalPlaces1.TwoDecimalPlaces(10.1289767789), Is.EqualTo(10.12));
    }

    [Test, Order(2)]
    public void Test_Negative_02()
    {
        Assert.That(FormattingDecimalPlaces1.TwoDecimalPlaces(-7488.83485834983), Is.EqualTo(-7488.83));
    }
}
