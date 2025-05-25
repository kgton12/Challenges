namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1117
{
    public static void NoteValidation()
    {
        List<double> notes = new List<double>();

        while (true)
        {
            double note = Convert.ToDouble(Console.ReadLine());

            if (note >= 0 && note <= 10)
                notes.Add(note);
            else
                Console.WriteLine("nota invalida");

            if (notes.Count == 2) break;
        }

        double average = notes.Average();
        Console.WriteLine($"media = {average:F2}");
    }
}
