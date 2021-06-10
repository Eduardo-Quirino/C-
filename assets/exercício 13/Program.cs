using System;

namespace exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
int anos, meses, dias, total_de_dias;
//Entradas
Console.WriteLine("Conversão de tempo de vida em Dias...");
Console.WriteLine("Digite a quantidade de anos: ");
anos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de meses: ");
meses = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de dias: ");
dias = Convert.ToInt32(Console.ReadLine());
//Processamento
total_de_dias = 365 * anos + 30 * meses + dias;
//Saída
Console.WriteLine("A pessoa viveu " + total_de_dias + " dias.");
Console.ReadKey();

        }
    }
}
