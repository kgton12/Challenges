using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HellsKitchenTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(HellsKitchen.Gordon("What feck damn cake"), Is.EqualTo("WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!"));
        Assert.That(HellsKitchen.Gordon("are you stu pid"), Is.EqualTo("@R*!!!! Y**!!!! ST*!!!! P*D!!!!"));
        Assert.That(HellsKitchen.Gordon("i am a chef"), Is.EqualTo("*!!!! @M!!!! @!!!! CH*F!!!!"));
    }
}
