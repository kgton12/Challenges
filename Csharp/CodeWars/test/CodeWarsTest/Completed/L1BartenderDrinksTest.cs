using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class L1BartenderDrinksTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("jabrOni"), Is.EqualTo("Patron Tequila"), "'Jabroni' should map to 'Patron Tequila'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("scHOOl counselor"), Is.EqualTo("Anything with Alcohol"), "'School Counselor' should map to 'Anything with alcohol'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("prOgramMer"), Is.EqualTo("Hipster Craft Beer"), "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("bike ganG member"), Is.EqualTo("Moonshine"), "'Bike Gang Member' should map to 'Moonshine'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("poLiTiCian"), Is.EqualTo("Your tax dollars"), "'Politician' should map to 'Your tax dollars'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("rapper"), Is.EqualTo("Cristal"), "'Rapper' should map to 'Cristal'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("pundit"), Is.EqualTo("Beer"), "'Pundit' should map to 'Beer'");
            Assert.That(L1BartenderDrinks.GetDrinkByProfession("Pug"), Is.EqualTo("Beer"), "'Pug' should map to 'Beer'");
        }
    }
}
