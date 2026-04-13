namespace CodeWars.Completed;

public class ChineseZodiacClass
{
    public static string ChineseZodiac(int year)
    {
        int initialYear = 1924;
        string[] animals = ["Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"];
        string[] elements = ["Wood", "Fire", "Earth", "Metal", "Water"];

        int yearsElapsed = year - initialYear;
        int animalIndex = ((yearsElapsed % 12) + 12) % 12;
        int elementIndex = (((yearsElapsed % 10) + 10) % 10) / 2;

        return $"{elements[elementIndex]} {animals[animalIndex]}";
    }
}