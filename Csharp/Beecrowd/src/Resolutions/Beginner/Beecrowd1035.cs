namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1035
{
    public static void SelectionTest1()
    {
        string[] inputLine = (Console.ReadLine() ?? "").Split(' ');
        int A = int.Parse(inputLine[0]);
        int B = int.Parse(inputLine[1]);
        int C = int.Parse(inputLine[2]);
        int D = int.Parse(inputLine[3]);

        if (B > C && D > A && (C + D) > (A + B) && C >= 0 && D >= 0 && A % 2 == 0)
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }
}
