using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FormattingDecimalPlaces0Test
{
    [Test, Order(1)]
    public void Test_01()
    {
        Assert.That(Formattingdecimalplaces0.TwoDecimalPlaces(4.659725356), Is.EqualTo(4.66));
    }

    [Test, Order(2)]
    public void Test_02()
    {
        Assert.That(Formattingdecimalplaces0.TwoDecimalPlaces(173735326.3783732637948948), Is.EqualTo(173735326.38));
    }
}
