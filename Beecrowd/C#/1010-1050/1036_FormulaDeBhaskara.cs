using System.Globalization;

namespace Beecrowd
{
    public class _1036_FormulaDeBhaskara
    {
        public string Bhaskara(string l)
        {
            double A, B, C, T;
            string[] linha = l.Split(' ');

            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);

            if (((B * B) - 4 * A * C) < 0 || A == 0)
            {
                return ("Impossivel calcular");
            }
            else
            {
                T = Math.Sqrt((B * B) - 4 * A * C);
                return ($"R1 = {((-B + T) / (2 * A)):f5}\n\r" +
                        $"R2 = {((-B - T) / (2 * A)):f5}");
            }
        }
    }
}
