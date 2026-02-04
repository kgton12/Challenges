using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TurkishNumbers099Test
{
    [Test]
    public void ExampleTest()
    {
        int[] exampleInputs = [1, 13, 27, 38, 77, 94];
        string[] exampleOutputs = ["bir", "on üç", "yirmi yedi", "otuz sekiz", "yetmiş yedi", "doksan dört"];

        for (int i = 0; i < exampleInputs.Length; i++)
        {
            Assert.That(TurkishNumbers099.GetTurkishNumber(exampleInputs[i]), Is.EqualTo(exampleOutputs[i]));
        }
    }
}
