using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_4_LerTemeratura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Muitos aises estão assando a utilizar o sistema métrico. Crie um algoritimo que leia uma temeratura dada em graus Farenheit e imprimir o equivalente em Celcius.
               tc = 5 * (tf-32)/9
             */

            //entrada
            double tf, tc;

            Console.WriteLine("Programa de leitura e conversão de temeperatura Farenheit para Celcius");
           
            Console.WriteLine("Informe a temperatura em Farenheit:  ");//imprime no console 
            tf = Convert.ToDouble(Console.ReadLine());//converte valor digitado

            //processamento
            tc = 5 * (tf-32) /9;//calculo

            //saida
            Console.WriteLine(tf + "°F equivale a: " + Math.Round (tc,1) + "°C");//imprime resultado 
            Console.ReadKey();//aguarda
        }
    }
}
