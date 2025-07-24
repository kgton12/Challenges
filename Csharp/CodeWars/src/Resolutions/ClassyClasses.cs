namespace CodeWars.src.Resolutions;

public class Person(string name, int age)
{
    public string Info { get; set; } = $"{name}s age is {age}";
}