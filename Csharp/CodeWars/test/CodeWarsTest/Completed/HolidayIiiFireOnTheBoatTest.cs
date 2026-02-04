using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HolidayIiiFireOnTheBoatTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HolidayIiiFireOnTheBoat.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"), Is.EqualTo("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast"));
            Assert.That(HolidayIiiFireOnTheBoat.FireFight("Mast Deck Engine Water Fire"), Is.EqualTo("Mast Deck Engine Water ~~"));
            Assert.That(HolidayIiiFireOnTheBoat.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"), Is.EqualTo("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain"));
        }
    }
}
