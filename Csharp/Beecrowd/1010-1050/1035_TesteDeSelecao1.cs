
namespace Beecrowd
{
    public class _1035_TesteDeSelecao1
    {
        public string TesteDeSelecao1(string l)
        {
            string[] linha = l.Split(' ');
            int A = int.Parse(linha[0]);
            int B = int.Parse(linha[1]);
            int C = int.Parse(linha[2]);
            int D = int.Parse(linha[3]);

            if (B > C && D > A && (C + D) > (A + B) && C >= 0 && D >= 0 && A % 2 == 0)
            {
                return ("Valores aceitos");
            }
            else
            {
                return ("Valores nao aceitos");
            }
        }
    }
}
