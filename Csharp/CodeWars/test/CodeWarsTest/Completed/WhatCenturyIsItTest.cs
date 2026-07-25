using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WhatCenturyIsItTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WhatCenturyIsIt.WhatCentury("1999"), Is.EqualTo("20th"), "With input '1999' solution produced wrong output.");
            Assert.That(WhatCenturyIsIt.WhatCentury("2011"), Is.EqualTo("21st"), "With input '2011' solution produced wrong output.");
            Assert.That(WhatCenturyIsIt.WhatCentury("2154"), Is.EqualTo("22nd"), "With input '2154' solution produced wrong output.");
            Assert.That(WhatCenturyIsIt.WhatCentury("2259"), Is.EqualTo("23rd"), "With input '2259' solution produced wrong output.");
            Assert.That(WhatCenturyIsIt.WhatCentury("1124"), Is.EqualTo("12th"), "With input '1124' solution produced wrong output.");
            Assert.That(WhatCenturyIsIt.WhatCentury("2000"), Is.EqualTo("20th"), "With input '2000' solution produced wrong output.");
        }
    }
}