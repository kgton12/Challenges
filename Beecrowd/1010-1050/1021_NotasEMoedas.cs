using System.Globalization;

namespace Beecrowd
{
    public class _1021_NotasEMoedas
    {
        public string NotasEMoedas(string d)
        {
            int dinheiro1, cem, cinquenta, cinquenta1, vinte, vinte1, dez, dez1, cinco, cinco1, dois, dois1;

            int moedas, um, um1, cinquentacen, vintecen, dezcen, cincocen, umcen;

            double dinheiro;

            dinheiro = double.Parse(d, CultureInfo.InvariantCulture);
            dinheiro1 = (int)dinheiro;
            dinheiro -= dinheiro1;

            moedas = (int)(dinheiro * 100);

            cem = dinheiro1 / 100;
            cinquenta = dinheiro1 % 100;
            cinquenta1 = cinquenta / 50;
            vinte = cinquenta % 50;
            vinte1 = vinte / 20;
            dez = vinte % 20;
            dez1 = dez / 10;
            cinco = dez % 10;
            cinco1 = cinco / 5;
            dois = cinco % 5;
            dois1 = dois / 2;

            um = dois % 2;
            um1 = um / 1;

            cinquentacen = moedas / 50;
            vintecen = (moedas % 50) / 25;
            dezcen = (((moedas % 50) % 25) / 10);
            cincocen = ((((moedas % 50) % 25) % 10) / 5);
            umcen = ((((moedas % 50) % 25) % 10) % 5) / 1;

            return ($"NOTAS:\n\r" +
            $"{cem} nota(s) de R$ 100.00\n\r" +
            $"{cinquenta1} nota(s) de R$ 50.00\n\r" +
            $"{vinte1} nota(s) de R$ 20.00\n\r" +
            $"{dez1} nota(s) de R$ 10.00\n\r" +
            $"{cinco1} nota(s) de R$ 5.00\n\r" +
            $"{dois1} nota(s) de R$ 2.00\n\r" +
            $"MOEDAS:\n\r" +
            $"{um1} moeda(s) de R$ 1.00\n\r" +
            $"{cinquentacen} moeda(s) de R$ 0.50\n\r" +
            $"{vintecen} moeda(s) de R$ 0.25\n\r" +
            $"{dezcen} moeda(s) de R$ 0.10\n\r" +
            $"{cincocen} moeda(s) de R$ 0.05\n\r" +
            $"{umcen} moeda(s) de R$ 0.01");
        }
    }
}
