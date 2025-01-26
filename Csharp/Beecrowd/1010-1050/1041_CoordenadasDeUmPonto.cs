using System.Globalization;

namespace Beecrowd
{
    public class _1041_CoordenadasDeUmPonto
    {
        public string CoordenadasDeUmPonto(string l)
        {
            double y, x;
            string[] linha = l.Split(' ');
            x = double.Parse(linha[0], CultureInfo.InvariantCulture);
            y = double.Parse(linha[1], CultureInfo.InvariantCulture);

            if (x + y == 0)
            {
                return ("Origem");
            }
            else if (x == 0)
            {
                return ("Eixo Y");
            }
            else if (y == 0)
            {
                return ("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                return ("Q1");
            }
            else if (x > 0 && y < 0)
            {
                return ("Q4");
            }
            else if (x < 0 && y > 0)
            {
                return ("Q2");
            }
            else if (x < 0 && y < 0)
            {
                return ("Q3");
            }
            else
            {
                return ("");
            }
        }
    }
}
