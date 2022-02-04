using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            int h, m,s, total_segundos;
            Console.WriteLine("Conversão de temo ara segundos");
            Console.WriteLine("Digite uma quantidade de Horas: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma quantidade de minutos: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma quantidade de segundos: ");
            s = Convert.ToInt32(Console.ReadLine());


            //prosessamento
            total_segundos = h * 3600 + m * 60 + s;

            //saida
            Console.WriteLine("Total de segundos = " + total_segundos + " seg.");
            Console.ReadKey();
        }
    }
}
