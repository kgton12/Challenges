namespace Beecrowd
{
    public class _1020_IdadeEmDias
    {
        public string IdadeEmDias(string d)
        {
            int dias = int.Parse(d);

            int ano = (int)(dias / 365);
            dias = dias - (ano * 365);

            int mes = (int)(dias / 30);
            dias = dias - (mes * 30);

            int dia = dias;

            return ($"{ano} ano(s)\n\r" +
                    $"{mes} mes(es)\n\r" +
                    $"{dia} dia(s)\n\r");

        }
    }
}
