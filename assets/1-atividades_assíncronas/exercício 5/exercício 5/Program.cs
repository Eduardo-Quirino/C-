using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programação n°1
             Ex-5. Crie um algoritmo que leia um valor de horas, minutos e segundos e transforme-o para segundos: (1h = 3600 seg. e 1 min =60 seg.)
            Ex:h = 2, min = 20, seg = 50 => total de segundos = 2*3600 + 20* 60 + 50 = 8450 seg.
             */

            //ENTRADA
            int h, min, seg,total;
            Console.WriteLine("Conversão de Tempo  a Segundos...");//informa sobre oque se trata
            Console.WriteLine("Digite uma quantidade de horas:");//pede a iformação no console
            h = Convert.ToInt32(Console.ReadLine());//recebe e converte informação de (h) no console

            Console.WriteLine("Digite uma quantidade de minutos:");//pede a iformação no console
            min = Convert.ToInt32(Console.ReadLine());//recebe e converte informação de (min) no console

            Console.WriteLine("Digite uma quantidade de segundos:");//pede a iformação no console
            seg = Convert.ToInt32(Console.ReadLine());//recebe e converte informação de (seg) no console
            total = h + 3600 + min * 60 + seg;

            //PROCESSAMENTO
            Console.WriteLine("Total convertido = " + total + " segundos");

            //SAIDA
            Console.ReadKey();
        }
    }
}
