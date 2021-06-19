using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programação n° 2
             Ex 1 - Crie um algoritimo que leia uma temperatura dada em graus Farenheit e imprima o em Celsius. 
             */

            //ENTRADA
            double tc, tf;//variáveis, variável do tipo real
            Console.WriteLine("Conversão de Temperatura de Farenheit a Celsius");//aqui informa conteúdo do programa
            Console.WriteLine("Digite uma temperatura, em graus Farenheit: ");//pede informação a ser processada
            tf = Convert.ToDouble(Console.ReadLine());//recebe texto como STRING faz a conversão para o tipo da VARIÁVEL 

            //PROCESSAMENTO
            tc = 5 * (tf - 32) / 9;//dados para aplicar na VARIÁVEL
            Console.WriteLine(tf + "ºF equivalem a: " + Math.Round(tc, 1) + "ºC");//imprime no console--> Math.Round(tc, 1)==> limita a quantidade de casas decimais

            //SAIDA
            Console.ReadKey();//permite que console fique aberto até o precionamento da tecla ENTER
        }
    }
}
