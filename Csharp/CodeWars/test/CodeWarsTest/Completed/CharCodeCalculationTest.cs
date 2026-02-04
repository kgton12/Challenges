using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CharCodeCalculationTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CharCodeCalculation.Calc(""), Is.Zero);
            Assert.That(CharCodeCalculation.Calc("abc"), Is.EqualTo(6));
            Assert.That(CharCodeCalculation.Calc("ABC"), Is.EqualTo(6));
            Assert.That(CharCodeCalculation.Calc("abcdef"), Is.EqualTo(6));
            Assert.That(CharCodeCalculation.Calc("ifkhchlhfd"), Is.EqualTo(6));
            Assert.That(CharCodeCalculation.Calc("jfmgklf8hglbe"), Is.EqualTo(6));
            Assert.That(CharCodeCalculation.Calc("jaam"), Is.EqualTo(12));
            Assert.That(CharCodeCalculation.Calc("AFHJD"), Is.EqualTo(18));
            Assert.That(CharCodeCalculation.Calc("CodeWars"), Is.EqualTo(18));
            Assert.That(CharCodeCalculation.Calc("FVJFVDF"), Is.EqualTo(24));
            Assert.That(CharCodeCalculation.Calc("AOUCUAOF"), Is.EqualTo(24));
            Assert.That(CharCodeCalculation.Calc("aaaaaddddr"), Is.EqualTo(30));
            Assert.That(CharCodeCalculation.Calc("XLdNDcAbUkMnkV"), Is.EqualTo(36));
            Assert.That(CharCodeCalculation.Calc("cSuLifxDQkOiypJsxOJSE"), Is.EqualTo(42));
            Assert.That(CharCodeCalculation.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"), Is.EqualTo(48));
            Assert.That(CharCodeCalculation.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"), Is.EqualTo(54));
            Assert.That(CharCodeCalculation.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"), Is.EqualTo(60));
            Assert.That(CharCodeCalculation.Calc("oXoQKiCflHIHFyGizCYCuaHhX"), Is.EqualTo(72));
            Assert.That(CharCodeCalculation.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"), Is.EqualTo(84));
        }
    }
}
