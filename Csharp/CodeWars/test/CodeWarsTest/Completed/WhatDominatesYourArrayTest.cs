using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WhatDominatesYourArrayTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(WhatDominatesYourArray.WhoDominates(new int[] { 3, 4, 3, 2, 3, 1, 3, 3 }), Is.EqualTo(3));
        Assert.That(WhatDominatesYourArray.WhoDominates(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(-1));
        Assert.That(WhatDominatesYourArray.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2 }), Is.EqualTo(-1));
        Assert.That(WhatDominatesYourArray.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2, 2 }), Is.EqualTo(2));
    }
}
