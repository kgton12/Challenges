using System.Globalization;

namespace Beecrowd._1010_1050
{
    public class _1045_TiposDeTriangulos
    {
        public string TiposDeTriangulos(string l)
        {
            double A, B, C;
            string[] linha = l.Split(' ');

            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            C = double.Parse(linha[2], CultureInfo.InvariantCulture);


            if (A >= (B + C) || B >= (A + C) || C >= (A + B))
                return ("NAO FORMA TRIANGULO");
            else if (A * A == (B * B + C * C) || B * B == (A * A + C * C) || C * C == (A * A + B * B))
                return ("TRIANGULO RETANGULO");
            else if (A * A > (B * B + C * C) || B * B > (A * A + C * C) || C * C > (A * A + B * B))
                return ("TRIANGULO OBTUSANGULO");
            else if (A * A < (B * B + C * C) || B * B < (A * A + C * C) || C * C < (A * A + B * B))
                return ("TRIANGULO ACUTANGULO");
            if (A == B && A == C)
                return ("TRIANGULO EQUILATERO");
            if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
                return ("TRIANGULO ISOSCELES");

            return ("Não é um triangulo");
        }
    }
}
