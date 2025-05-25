using System.Globalization;

namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1040
{
    public static void Average3()
    {
        float n1, n2, n3, n4, average, exam;

        string[] s = (Console.ReadLine() ?? string.Empty).Split(' ');

        n1 = float.Parse(s[0], CultureInfo.InvariantCulture);
        n2 = float.Parse(s[1], CultureInfo.InvariantCulture);
        n3 = float.Parse(s[2], CultureInfo.InvariantCulture);
        n4 = float.Parse(s[3], CultureInfo.InvariantCulture);

        average = ((n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1));

        if (average >= 7.0)
        {
            Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            if (average < 5.0)
            {
                Console.WriteLine("Media: {0:f1}", (average - 0.01).ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Media: {0:f1}", (average - 0.01).ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                exam = float.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exam.ToString("F1", CultureInfo.InvariantCulture));
                average = (average + exam) / 2;

                if (average >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado.");

                Console.WriteLine("Media final: " + average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
