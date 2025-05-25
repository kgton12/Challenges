namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1049
{
    public static void Animal()
    {
        string word1, word2, word3;

        word1 = Console.ReadLine() ?? string.Empty;
        word2 = Console.ReadLine() ?? string.Empty;
        word3 = Console.ReadLine() ?? string.Empty;

        if (word1 == "vertebrado")
        {
            if (word2 == "ave")
            {
                if (word3 == "carnivoro")
                    Console.WriteLine("aguia");
                else if (word3 == "onivoro")
                    Console.WriteLine("pomba");
            }
            else if (word2 == "mamifero")
            {
                if (word3 == "onivoro")
                    Console.WriteLine("homem");
                else if (word3 == "herbivoro")
                    Console.WriteLine("vaca");
            }
        }
        else if (word1 == "invertebrado")
        {
            if (word2 == "inseto")
            {
                if (word3 == "hematofago")
                    Console.WriteLine("pulga");
                else if (word3 == "herbivoro")
                    Console.WriteLine("lagarta");
            }
            else if (word2 == "anelideo")
            {
                if (word3 == "hematofago")
                    Console.WriteLine("sanguessuga");
                else if (word3 == "onivoro")
                    Console.WriteLine("minhoca");
            }
        }
    }
}
