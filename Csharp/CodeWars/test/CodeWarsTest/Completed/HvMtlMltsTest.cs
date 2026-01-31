using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HvMtlMltsTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(HvMtlMlts.HeavyMetalUmlauts("Announcing the Macbook Air Guitar"), Is.EqualTo("Ännöüncïng thë Mäcböök Äïr Güïtär"));
        Assert.That(HvMtlMlts.HeavyMetalUmlauts("Facebook introduces new heavy metal reaction buttons"), Is.EqualTo("Fäcëböök ïntrödücës nëw hëävÿ mëtäl rëäctïön büttöns"));
        Assert.That(HvMtlMlts.HeavyMetalUmlauts("Strong sales of Google's VR Metalheadsets send tech stock prices soaring"), Is.EqualTo("Ströng sälës öf Gööglë's VR Mëtälhëädsëts sënd tëch stöck prïcës söärïng"));
        Assert.That(HvMtlMlts.HeavyMetalUmlauts("Vegan Black Metal Chef hits the big time on Amazon TV"), Is.EqualTo("Vëgän Bläck Mëtäl Chëf hïts thë bïg tïmë ön Ämäzön TV"));
    }
}
