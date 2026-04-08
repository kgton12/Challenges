using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class KookacounterTest
{
    private static readonly object[] Basic_Test_Cases =
        [
      new object[] {String.Empty, 0},
      new object[] {"hahahahaha", 1},
      new object[] {"hahahahahaHaHaHa", 2},
      new object[] {"HaHaHahahaHaHa", 3}
        ];

    [Test, TestCaseSource(typeof(KookacounterTest), nameof(Basic_Test_Cases))]
    public void Basic_Test(string laughing, int expected)
    {
        Assert.That(Kookacounter.KookaCounter(laughing), Is.EqualTo(expected));
    }
}
