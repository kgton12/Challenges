namespace Beecrowd
{
    public class _1017_GastoDeCombustivel
    {
        public string GastoDeCombustivel(string tg, string vm)
        {
            int tempoGasto = int.Parse(tg);
            int velocidadeMedia = int.Parse(vm);

            double litros = tempoGasto * velocidadeMedia / 12.0;

            return ($"{litros:f3}");
        }
    }
}
