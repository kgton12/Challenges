using System.Globalization;

namespace Beecrowd._1051_1099
{
    public class _1051_ImpostoDeRenda
    {
        public string ImpostoDeRenda(string l)
        {
            double renda = double.Parse(l, CultureInfo.InvariantCulture);

            if (renda <= 2000.00f)
            {
                return ("Isento");
            }
            else if (renda <= 3000.00f)
            {
                renda -= 2000.00f;
                renda *= 0.08;
                return ("R$ {0:F2}", renda).ToString();
            }
            else if (renda <= 4500.00f)
            {
                renda -= 3000.00f;
                renda *= 0.18;
                renda += (1000 * 0.08);
                return ("R$ {0:F2}", renda).ToString();
            }
            else
            {
                renda -= 4500.00f;
                renda *= 0.28;
                renda += (1500 * 0.18) + (1000 * 0.08);
                return ("R$ {0:F2}", renda).ToString();
            }
        }
    }
}
