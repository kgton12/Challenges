using System.Globalization;

namespace Beecrowd
{
    public class _1011_Esfera
    {
        public string Esfera(string r)
        {
            string raio = r;

            double massa = (4.0 / 3.0) * 3.14159 * Math.Pow(double.Parse(raio, CultureInfo.InvariantCulture), 3);

            return ($"VOLUME = {massa:f3}");
        }
    }
}
