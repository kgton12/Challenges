
using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FunWithEs6Classes1PeoplePeoplePeopleTest
{
    [Test, Description("should have the correct defaults"), Order(1)]
    public void DefaultArgsTest()
    {
        FunWithEs6Classes1PeoplePeoplePeoplePerson person = new();
        using (Assert.EnterMultipleScope())
        {
            Assert.That(person.FirstName, Is.EqualTo("John"));
            Assert.That(person.LastName, Is.EqualTo("Doe"));
            Assert.That(person.Age, Is.Zero);
            Assert.That(person.Gender, Is.EqualTo("Male"));
            Assert.That(person.SayFullName(), Is.EqualTo("John Doe"));
        }
    }

    [Test, Description("should work with a person Jane Doe"), Order(2)]
    public void CustomTest()
    {
        FunWithEs6Classes1PeoplePeoplePeoplePerson person = new("Jane", "Doe", 25, "Female");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(person.FirstName, Is.EqualTo("Jane"));
            Assert.That(person.LastName, Is.EqualTo("Doe"));
            Assert.That(person.Age, Is.EqualTo(25));
            Assert.That(person.Gender, Is.EqualTo("Female"));
            Assert.That(person.SayFullName(), Is.EqualTo("Jane Doe"));
        }
    }
}
