using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HeronsFormulaTest
{
    [Test, Description("Heron(3, 4, 5)")]
    public void Triangle_3_4_5()
    {
        Assert.That(HeronsFormula.Heron(3, 4, 5), Is.EqualTo(6).Within(0.01));
    }

    [Test, Description("Heron(4, 4, 4)")]
    public void Triangle_4_4_4()
    {
        Assert.That(HeronsFormula.Heron(4, 4, 4), Is.EqualTo(Math.Sqrt(3) * 4).Within(0.01));
    }
}
