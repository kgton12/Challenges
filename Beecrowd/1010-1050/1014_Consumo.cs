using System.Globalization;

namespace Beecrowd
{
    public class _1014_Consumo
    {
        public string Consumo(string k, string g)
        {
            int km = int.Parse(k, CultureInfo.InvariantCulture);
            double gas = double.Parse(g, CultureInfo.InvariantCulture);

            double media = Math.Round(km / gas, 3);

            return ($"{media:f3} km/l");
        }
    }
}
