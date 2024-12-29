
using System.Globalization;

namespace Beecrowd
{
    public class _1012_Area
    {
        public string Area(string l)
        {
            string[] linha = l.Split(' ');
            double A, B, C;
            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);

            double quadrado = Math.Round((B * B), 3);
            double retangulo = Math.Round((A * B), 3);
            double trapezio = Math.Round((((A + B) * C) / 2), 3);
            double circulo = Math.Round((3.14159 * Math.Pow(C, 2)), 3);
            double triangulo = Math.Round(((A * C) / 2), 3);


            return ($"TRIANGULO: {triangulo:f3}\n\r" +
                    $"CIRCULO: {circulo:f3}\n\r" +
                    $"TRAPEZIO: {trapezio:f3}\n\r" +
                    $"QUADRADO: {quadrado:f3}\n\r" +
                    $"RETANGULO: {retangulo:f3}");
        }
    }
}
