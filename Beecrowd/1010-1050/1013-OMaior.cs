namespace Beecrowd
{
    public class _1013_OMaior
    {
        public string OMaior(string l)
        {
            string[] linha = l.Split(' ');

            int A, B, C, maiorAB, maior;
            A = int.Parse(linha[0]);
            B = int.Parse(linha[1]);
            C = int.Parse(linha[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = maiorAB > C ? maiorAB : C;

            return ($"{maior} eh o maior");
        }
    }
}
