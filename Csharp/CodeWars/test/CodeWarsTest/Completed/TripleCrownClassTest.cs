using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TripleCrownClassTest
{
    [Test, Order(1)]
    public void FixedTestOne()
    {
        Dictionary<string, Dictionary<string, int>> receivers = new Dictionary<string, Dictionary<string, int>>()
        {
          { "Cooper Kupp", new Dictionary<string, int>()
            {
              { "Receiving yards", 1800 },
              { "Receiving touchdowns", 18 },
              { "Receptions", 117 }
            }
          },
          { "Justin Jefferson",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1700 },
              { "Receiving touchdowns", 17 },
              { "Receptions", 116 }
            }
          },
          { "Davante Adams",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1750 },
              { "Receiving touchdowns", 16 },
              { "Receptions", 113 }
            }
          }
        };

        var expected = "Cooper Kupp";

        var actual = TripleCrownClass.TripleCrown(receivers);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void FixedTestTwo()
    {
        Dictionary<string, Dictionary<string, int>> receivers = new Dictionary<string, Dictionary<string, int>>()
        {
          { "Cooper Kupp", new Dictionary<string, int>()
            {
              { "Receiving yards", 1700 },
              { "Receiving touchdowns", 18 },
              { "Receptions", 117 }
            }
          },
          { "Justin Jefferson",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1650 },
              { "Receiving touchdowns", 17 },
              { "Receptions", 115 }
            }
          },
          { "Davante Adams",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1750 },
              { "Receiving touchdowns", 16 },
              { "Receptions", 113 }
            }
          }
        };

        var expected = "None of them";

        var actual = TripleCrownClass.TripleCrown(receivers);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void FixedTestThree()
    {
        Dictionary<string, Dictionary<string, int>> receivers = new Dictionary<string, Dictionary<string, int>>()
        {
          { "Cooper Kupp", new Dictionary<string, int>()
            {
              { "Receiving yards", 1800 },
              { "Receiving touchdowns", 16 },
              { "Receptions", 110 }
            }
          },
          { "Justin Jefferson",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1725 },
              { "Receiving touchdowns", 15 },
              { "Receptions", 112 }
            }
          },
          { "Davante Adams",
           new Dictionary<string, int>()
            {
             { "Receiving yards", 1800 },
              { "Receiving touchdowns", 16 },
              { "Receptions", 113 }
            }
          }
        };

        var expected = "None of them";

        var actual = TripleCrownClass.TripleCrown(receivers);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
