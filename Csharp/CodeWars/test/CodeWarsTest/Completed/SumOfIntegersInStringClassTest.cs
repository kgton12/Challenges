using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumOfIntegersInStringClassTest
{
    private static readonly object[] sampleTests =
       [
      new object[] {"12.4", 16},
      new object[] {"h3ll0w0rld", 3},
      new object[] {"2 + 3 = ", 5},
      new object[] {"Our company made approximately 1 million in gross revenue last quarter.", 1},
      new object[] {"The Great Depression lasted from 1929 to 1939.", 3868},
      new object[] {"Dogs are our best friends.", 0},
      new object[] {"C4t5 are 4m4z1ng.", 18},
      new object[] {"The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", 3635},
       ];

    [Test, TestCaseSource(nameof(sampleTests))]
    public void SampleTest(string test, int expected) => Assert.That(SumOfIntegersInStringClass.SumOfIntegersInString(test), Is.EqualTo(expected));
}

