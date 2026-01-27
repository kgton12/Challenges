namespace CodeWars.Resolutions
{
    public class Person1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person1(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public string SayFullName() => $"{FirstName} {LastName}";

        public static string GreetExtraTerrestrials(string raceName) => $"Welcome to Planet Earth {raceName}";
    }
}
