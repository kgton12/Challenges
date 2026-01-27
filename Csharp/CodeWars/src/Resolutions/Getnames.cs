namespace CodeWars.Resolutions;

public class Getnames
{
    public class Person(string name = "John", int age = 21)
    {
        public int Age = age;
        public string Name = name;
    }
    public static string[] GetNames(Person[] data) =>
        [.. data.Select(x => x.Name)];
}
