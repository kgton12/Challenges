using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NewCashierDoesNotKnowAboutSpaceOrShiftTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(NewCashierDoesNotKnowAboutSpaceOrShift.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"),
        Is.EqualTo("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(NewCashierDoesNotKnowAboutSpaceOrShift.GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"),
        Is.EqualTo("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke"));
    }
}
