using System.Globalization;

namespace Beecrowd
{
    public class _1010_CalculoSimples
    {
        public String CalculoSimples(string str1, string str2)
        {
            string[] linha1 = str1.Split(' ');
            string[] linha2 = str2.Split(' ');

            Double vltotal = (Convert.ToInt32(linha1[1]) * double.Parse(linha1[2], CultureInfo.InvariantCulture)) +
                             (Convert.ToInt32(linha2[1]) * double.Parse(linha2[2], CultureInfo.InvariantCulture));

            return ($"VALOR A PAGAR: R$ {vltotal:f2}");
        }
    }
}
