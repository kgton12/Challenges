
namespace Beecrowd._1010_1050
{
    public class _1047_TempoDeJogoComMinutos
    {
        public string TempoDeJogoComMinutos(string l)
        {
            int A, B, C, D;
            string[] linha = l.Split(' ');

            A = int.Parse(linha[0]);
            B = int.Parse(linha[1]);
            C = int.Parse(linha[2]);
            D = int.Parse(linha[3]);

            var hora1 = new TimeSpan(A, B, 00);
            var hora2 = new TimeSpan(C, D, 00);
            TimeSpan result = new TimeSpan(00, 00, 00);

            if (hora1 > hora2)
            {
                TimeSpan diaAtual = new TimeSpan(24, 00, 00);
                result = diaAtual - hora1;
                result = result + hora2;
                return ($"O JOGO DUROU {result.Hours} HORA(S) E {result.Minutes} MINUTO(S)");
            }
            else if (hora1 < hora2)
            {
                result = hora2 - hora1;
                return ($"O JOGO DUROU {result.Hours} HORA(S) E {result.Minutes} MINUTO(S)");

            }
            else if (hora1 == hora2)
            {
                return ("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                return ("Minutos incorretos");
            }

        }
    }
}
