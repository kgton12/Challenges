using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WhatDominatesYourArrayTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WhatDominatesYourArray.WhoDominates([3, 4, 3, 2, 3, 1, 3, 3]), Is.EqualTo(3));
            Assert.That(WhatDominatesYourArray.WhoDominates([1, 2, 3, 4, 5]), Is.EqualTo(-1));
            Assert.That(WhatDominatesYourArray.WhoDominates([1, 1, 1, 2, 2, 2]), Is.EqualTo(-1));
            Assert.That(WhatDominatesYourArray.WhoDominates([1, 1, 1, 2, 2, 2, 2]), Is.EqualTo(2));
        }
    }
}
