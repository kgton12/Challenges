namespace Beecrowd
{
    public class _1038_Lanche
    {
        public string Lanche(string l)
        {
            string[] linha = l.Split(' ');
            int cod = int.Parse(linha[0]);
            int qtd = int.Parse(linha[1]);
            double[] val = new double[] { 0.00, 4.00, 4.50, 5.00, 2.00, 1.50 };

            return ($"Total: R$ {(qtd * val[cod]):f2}");
        }
    }
}
