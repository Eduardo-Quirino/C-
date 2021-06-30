using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_47
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 
          Ex 9 - Crie um algoritimo que leia uma temperatura inicial em Farenheit e leia outra temperatura final em Farenheit também. Elabore uma tabela em ordem crescente com as temperaturas equivalentes em Celsius.
            C= 5*(F-32)/9
          */
            //ENTRADA
            double F,ti,tf, aux;
            Console.WriteLine("conversão de temperaturas Farenheit a Celsius:");
            Console.WriteLine("Digite uma temperatura inicial em °F: ");

            //PROCESSAMENTO
            ti = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma temperatura final, em °F: ");
            tf = double.Parse(Console.ReadLine());
            if (ti>tf) {
                aux = ti;
                ti = tf;
                tf = aux;
            }
            Console.WriteLine("\nTabela de conversão de temperaturas :\n\n");
            for  (F = ti; F <= tf; F++)
            {
                Console.WriteLine(F+" F° = "+Math.Round( 5*(F-32)/9,2)+ " °C");
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
