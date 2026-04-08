using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TurnAnyWordIntoABeefTacoTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TurnAnyWordIntoABeefTaco.Tacofy(""), Is.EqualTo(["shell", "shell"]));
            Assert.That(TurnAnyWordIntoABeefTaco.Tacofy("a"), Is.EqualTo(["shell", "beef", "shell"]));
            Assert.That(TurnAnyWordIntoABeefTaco.Tacofy("ggg"), Is.EqualTo(["shell", "guacamole", "guacamole", "guacamole", "shell"]));
            Assert.That(TurnAnyWordIntoABeefTaco.Tacofy("ogl"), Is.EqualTo(["shell", "beef", "guacamole", "lettuce", "shell"]));
            Assert.That(TurnAnyWordIntoABeefTaco.Tacofy("ydjkpwqrzto"), Is.EqualTo(["shell", "tomato", "beef", "shell"]));
        }
    }
}
