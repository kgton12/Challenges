namespace Beecrowd
{
    public class _1042_SortSimples
    {
        public string SortSimples(string l)
        {
            string[] linha = l.Split(' ');
            int[] linhaordenada = new int[3];
            string resp = "";

            for (int i = 0; i < linha.Length; i++)
            {
                linhaordenada[i] = Convert.ToInt16(linha[i]);
            }

            Array.Sort(linhaordenada);

            foreach (var item in linhaordenada)
            {
                resp += (item).ToString() + $"\n\r";
            }

            resp += ("" + "\n\r");

            foreach (var item in linha)
            {
                resp += (item).ToString() + $"\n\r";
            }

            return resp;
        }
    }
}
