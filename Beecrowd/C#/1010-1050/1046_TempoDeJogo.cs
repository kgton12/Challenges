
using System.Globalization;

namespace Beecrowd._1010_1050
{
    public class _1046_TempoDeJogo
    {
        public string TempoDeJogo(string l)
        {
            double A, B;
            string[] linha = l.Split(' ');

            A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            double result = 0;
            if (A == B)
            {
                return ("O JOGO DUROU 24 HORA(S)");
            }
            else if (A > B)
            {
                result = 24 - A;
                result = result + B;
                return ($"O JOGO DUROU {result} HORA(S)");
            }
            else if (A < B)
            {
                result = B - A;
                return ($"O JOGO DUROU {result} HORA(S)");
            }
            else
            {
                return ("Tempo incorreto");
            }
        }
    }
}
