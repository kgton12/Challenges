using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PlusMinusPlusPlusCountTest
{
    [Test, Order(1), Description("Lists With 0 Sign Changes")]
    public void ZeroChanges()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([]), Is.Zero, "input = {}:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([42]), Is.Zero, "input = { 42 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-42]), Is.Zero, "input = { -42 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([4, 1]), Is.Zero, "input = { 4, 1 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([0, 1]), Is.Zero, "input = { 0, 1 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([1, 0]), Is.Zero, "input = { 1, 0 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([0, 0, 0]), Is.Zero, "input = { 0, 0, 0 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-1, -2, -3]), Is.Zero, "input = { -1, -2, -3 }:");
        }
    }

    [Test, Order(2), Description("Lists With 1 Sign Change")]
    public void OneChange()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-3, 3]), Is.EqualTo(1), "input = { -3, 3 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([1, 5, 2, -4]), Is.EqualTo(1), "input = { 1, 5, 2, -4 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-7, -7, 7, 0]), Is.EqualTo(1), "input = { -7, -7, 7, 0 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([2, 6, 3, 0, 5, -3]), Is.EqualTo(1), "input = { 2, 6, 3, 0, 5, -3 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-2, -2, -5, -4, 5, 2, 0, 6, 0]), Is.EqualTo(1), "input = { -2, -2, -5, -4, 5, 2, 0, 6, 0 }:");
        }
    }

    [Test, Order(3), Description("Lists With 2 Sign Changes")]
    public void TwoChanges()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([1, -3, -4, 0, 5]), Is.EqualTo(2), "input = { 1, -3, -4, 0, 5 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([3, 7, -6, 2, 3, 1, 1]), Is.EqualTo(2), "input = { 3, 7, -6, 2, 3, 1, 1 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-1, 2, 2, 0, 2, -8, -1]), Is.EqualTo(2), "input = { -1, 2, 2, 0, 2, -8, -1 }:");
        }
    }

    [Test, Order(4), Description("Lists With 3+ Sign Changes")]
    public void MoreChanges()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-47, 84, -30, -11, -5, 74, 77]), Is.EqualTo(3), "input = { -47, 84, -30, -11, -5, 74, 77 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([-8, 4, -1, 5, -3, -3, -2, -2]), Is.EqualTo(4), "input = { -8, 4, -1, 5, -3, -3, -2, -2 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([13, -7, -6, 2, -1, 1, -1]), Is.EqualTo(5), "input = { 13, -7, -6, 2, -1, 1, -1 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([1, -2, -7, -4, 4, -2, 0, -3, 3]), Is.EqualTo(6), "input = { 1, -2, -7, -4, 4, -2, 0, -3, 3 }:");
            Assert.That(PlusMinusPlusPlusCount.CatchSignChange([0, 65, 34, -188, 123, 91, -154, 7, 45, -91, 178, 110, 100, -177, -15, -139, -96, -190, -19]), Is.EqualTo(7), "input = { 0, 65, 34, -188, 123, 91, -154, 7, 45, -91, 178, 110, 100, -177, -15, -139, -96, -190, -19 }:");
        }
    }
}
