using System.Globalization;

namespace Beecrowd._1010_1050
{
    public class _1043_Triangulo
    {
        public string Triangulo(string l)
        {
            double A, B, C, area, perimetro;
            string[] linha = l.Split(' ');

            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);

            if (B - C < A && B - C < B + C && A - C < B && A - C < A + C && A - B < C && A - B < A + B)
            {
                perimetro = A + B + C;
                return ("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                return ("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
