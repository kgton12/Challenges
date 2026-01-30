using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WhatIsBetweenTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WhatIsBetween.Between(0, 3), Is.EqualTo([0, 1, 2, 3]));
            Assert.That(WhatIsBetween.Between(-2, 2), Is.EqualTo([-2, -1, 0, 1, 2]));
            Assert.That(WhatIsBetween.Between(-10, 10), Is.EqualTo([-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));
        }
    }
}
