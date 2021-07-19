using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_98
{
    class Program
    {   /*crie um algoritimo(usando subalgoritimos) que leia uma temperatura dada em Farenheit e converta-a para Celsius. Sabendo que :

        tc = 5°(tf-32)/9
        */
        static void convert(double tf){
            double tc;
            tc = 5*(tf - 32) / 9;
            Console.WriteLine(tf +" °F = "+ Math.Round(tc,1));
        }
        
        static void Main(string[] args)
        {   //ENTRADA
            double F;
            Console.WriteLine("Conversão de temperatura F a Celsius:");
            Console.WriteLine("Digite uma temperatura em Farenheit");

            //PROCESSAMENTO
            F = double.Parse(Console.ReadLine());

            //SAIDA
            convert(F);
            Console.ReadKey();
        }
    }
}
