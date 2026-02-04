namespace CodeWars.Resolutions
{
    public class FunWithEs6Classes1PeoplePeoplePeoplePerson(
        string firstName = "John",
        string lastName = "Doe",
        int age = 0,
        string gender = "Male")
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;
        public string Gender { get; set; } = gender;

        public string SayFullName() => $"{FirstName} {LastName}";

        public static string GreetExtraTerrestrials(string raceName)
        {
            return $"Welcome to Planet Earth {raceName}";
        }
    }
}
