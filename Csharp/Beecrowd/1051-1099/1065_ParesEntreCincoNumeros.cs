namespace Beecrowd._1051_1099
{
    public class _1065_ParesEntreCincoNumeros
    {
        public string ParesEntreCincoNumeros(int[] l)
        {
            int[] linha = new int[5];
            int count = 0;
            linha = l;

            for (int i = 0; i < linha.Length; i++)
            {
                if (linha[i] % 2 == 0)
                {
                    count++;
                }
            }

            return ($"{count} valores pares");
        }
    }
}
