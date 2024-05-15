namespace Beecrowd._1051_1099
{
    public class _1060_NumerosPositivos
    {
        public string NumerosPositivos(double[] l)
        {
            double[] linha = l;

            linha[0] = double.Parse(Console.ReadLine());
            linha[1] = double.Parse(Console.ReadLine());
            linha[2] = double.Parse(Console.ReadLine());
            linha[3] = double.Parse(Console.ReadLine());
            linha[4] = double.Parse(Console.ReadLine());
            linha[5] = double.Parse(Console.ReadLine());

            int qtd = 0;

            for (int i = 0; i < linha.Length; i++)
            {
                if (linha[i] >= 0)
                {
                    qtd++;
                }
            }

            return ($"{qtd} valores positivos");
        }
    }
}
