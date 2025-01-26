using System.Globalization;

namespace Beecrowd
{
    public class _1015_DistanciaEntreDoisPontos
    {
        public string DistanciaEntreDoisPontos(string l1, string l2)
        {
            string[] linha1 = l1.Split(' ');
            string[] linha2 = l2.Split(' ');

            double x1, x2, y1, y2;

            x1 = double.Parse(linha1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(linha1[1], CultureInfo.InvariantCulture);

            x2 = double.Parse(linha2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(linha2[1], CultureInfo.InvariantCulture);

            double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);

            return ($"{result:f4}");
        }
    }
}
