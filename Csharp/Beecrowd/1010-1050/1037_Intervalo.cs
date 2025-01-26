using System.Globalization;

namespace Beecrowd
{
    public class _1037_Intervalo
    {
        public string Intervalo(string v)
        {
            double valor = double.Parse(v, CultureInfo.InvariantCulture);
            string msg;

            if (valor >= 0 && valor <= 25)
            {
                msg = "Intervalo [0,25]";
            }
            else if (valor >= 25 && valor <= 50)
            {
                msg = "Intervalo (25,50]";
            }
            else if (valor >= 50 && valor <= 75)
            {
                msg = "Intervalo (50,75]";
            }
            else if (valor >= 75 && valor <= 100)
            {
                msg = "Intervalo (75,100]";
            }
            else
            {
                msg = "Fora de intervalo";
            }
            return (msg);
        }
    }
}
