namespace Beecrowd
{
    public class _1044_Multiplos
    {
        public string Multiplos(string l)
        {
            int A, B;
            string[] linha = l.Split(' ');
            A = int.Parse(linha[0]);
            B = int.Parse(linha[1]);

            if (B % A == 0 || A % B == 0)
            {
                return ("Sao Multiplos");
            }
            else
            {
                return ("Nao sao Multiplos");
            }
        }
    }
}
