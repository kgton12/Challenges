using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheDifferenceInAgeBetweenOldestAndYoungestFamilyMembersTest
{
    [Test, Description("Should return expected results for sample tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheDifferenceInAgeBetweenOldestAndYoungestFamilyMembers.DifferenceInAges([82, 15, 6, 38, 35]), Is.EqualTo([6, 82, 76]));
            Assert.That(FindTheDifferenceInAgeBetweenOldestAndYoungestFamilyMembers.DifferenceInAges([57, 99, 14, 32]), Is.EqualTo([14, 99, 85]));
        }
    }
}
