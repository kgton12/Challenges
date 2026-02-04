using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SwitchcaseBugFixing6Test
{
    [Test]
    public static void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '+'), Is.EqualTo(2));
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '-'), Is.Zero);
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '/'), Is.EqualTo(1));
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '*'), Is.EqualTo(1));
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '%'), Is.Zero);
            Assert.That(SwitchcaseBugFixing6.EvalObject(1, 1, '^'), Is.EqualTo(1));
        }
    }
}
