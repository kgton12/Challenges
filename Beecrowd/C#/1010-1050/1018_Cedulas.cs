namespace Beecrowd
{
    public class _1018_Cedulas
    {
        public string Cedulas(string v)
        {
            int valor = int.Parse(v);
            int troco, cem, cinquenta, vinte, dez, cinco, dois;

            troco = valor;

            cem = troco / 100;

            troco = troco - (cem * 100);

            cinquenta = troco / 50;

            troco = troco - (cinquenta * 50);

            vinte = troco / 20;

            troco = troco - (vinte * 20);

            dez = troco / 10;

            troco = troco - (dez * 10);

            cinco = troco / 5;

            troco = troco - (cinco * 5);

            dois = troco / 2;

            troco = troco - (dois * 2);

            return ($"{valor}" +
                    $"{cem} nota(s) de R$ 100,00\n\r" +
                    $"{cinquenta} nota(s) de R$ 50,00\n\r" +
                    $"{vinte} nota(s) de R$ 20,00\n\r" +
                    $"{dez} nota(s) de R$ 10,00\n\r" +
                    $"{cinco} nota(s) de R$ 5,00\n\r" +
                    $"{dois} nota(s) de R$ 2,00\n\r" +
                    $"{troco} nota(s) de R$ 1,00");
        }
    }
}
