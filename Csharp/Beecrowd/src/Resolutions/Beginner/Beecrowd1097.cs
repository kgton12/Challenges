namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1097
{
    public static void SequenceIJ3()
    {
        int jAux = 7;
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = jAux; j > jAux - 3; j--)
                Console.WriteLine($"I={i} J={j}");

            jAux += 2;
        }
    }
}
