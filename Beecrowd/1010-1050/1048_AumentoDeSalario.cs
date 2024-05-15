using System.Globalization;

namespace Beecrowd._1010_1050
{
    public class _1048_AumentoDeSalario
    {
        public string AumentoDeSalario(string l)
        {
            double salario, aumento, novoSal;
            string[] linha = l.Split(' ');

            salario = double.Parse(linha[0], CultureInfo.InvariantCulture);

            if (salario > 0 && salario <= 400)
            {//15%
                aumento = salario * 0.15;
                novoSal = salario + aumento;
                return ($"Novo salario: {novoSal:f2}\n\r" +
                        $"Reajuste ganho: {aumento:f2}\n\r" +
                        $"Em percentual: 15 %");

            }
            else if (salario >= 400.01 && salario <= 800)
            {//12%
                aumento = salario * 0.12;
                novoSal = salario + aumento;
                return ($"Novo salario: {novoSal:f2}\n\r" +
                        $"Reajuste ganho: {aumento:f2}\n\r" +
                        $"Em percentual: 12 %");

            }
            else if (salario >= 800.01 && salario <= 1200)
            {//10%
                aumento = salario * 0.10;
                novoSal = salario + aumento;
                return ($"Novo salario: {novoSal:f2}\n\r" +
                        $"Reajuste ganho: {aumento:f2}\n\r" +
                        $"Em percentual: 10 %");

            }
            else if (salario >= 1200.01 && salario <= 2000)
            {//7%
                aumento = salario * 0.07;
                novoSal = salario + aumento;
                return ($"Novo salario: {novoSal:f2}\n\r" +
                        $"Reajuste ganho: {aumento:f2}\n\r" +
                        $"Em percentual: 7 %");

            }
            else if (salario > 2000)
            {//4%
                aumento = salario * 0.04;
                novoSal = salario + aumento;
                return ($"Novo salario: {novoSal:f2}\n\r" +
                        $"Reajuste ganho: {aumento:f2}\n\r" +
                        $"Em percentual: 4 %");
            }
            else
            {
                return ($"Novo salario: 0.00\n\r" +
                        $"Reajuste ganho: 0.00\n\r" +
                        $"Em percentual: 0.00 %");

            }
        }
    }
}
