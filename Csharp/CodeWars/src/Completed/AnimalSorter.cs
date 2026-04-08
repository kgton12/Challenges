namespace CodeWars.Completed;



public class AnimalSorter
{
    public class Animal
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfLegs { get; set; }
    }

    public List<Animal> Sort(List<Animal> input) =>
        [.. input.OrderBy(x => x.NumberOfLegs).ThenBy(x => x.Name)];
}

