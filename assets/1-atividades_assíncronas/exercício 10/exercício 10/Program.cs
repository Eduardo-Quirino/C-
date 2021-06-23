using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programação n° 2
             Ex 5 - Crie um algoritimo para ler os valores dos coeficientes A, B, e C de uma equação quadráda. Calcule e impriir o valor do discriminante(delta)
            DELTA = B² - 4 * A* C
             */

            //ENTRADA
            double A, B, C,delta;//variavel de tipo 
            Console.WriteLine("Calculando o valor de (DELTA) da equação de 2°Grau:" + " ax² + bx + c = 0");

   Console.WriteLine("Ditite o valor de A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = Convert.ToDouble(Console.ReadLine());



            //PROCESSAMENTO
            
            delta = Math.Pow(B,2) -4 * A * C;//eleva a potência B²
            Console.WriteLine("O discriminante (DELTA) vale: " + delta);

            //SAIDA
            Console.ReadKey();

        }
    }
}
