using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_67
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3° parte
         Crie um algoritmo que leia dois números inteiros
positivos e determine o máximo divisor comum entre
eles usando o algoritmo de Euclides:
            */

            //ENTRADA
            int a, b, resto, aux;
            Console.WriteLine("M D C - Máximo Divisor Comum entre dois n´´umeros positivos");

            //PROCESSAMENTO
            Console.WriteLine("Digite o valor do 1° número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 2° número: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                aux = a; a = b; b = aux;}//Com isso, a é maior que b, sempre
            resto = a % b;
            while (resto>0) { a = b; b = resto;resto = a % b; }
            Console.WriteLine("\n\nO MDC vale: " + b);
            Console.WriteLine("Pressione qualquer tecla para sair do programa....");

            //SAIDA
            Console.ReadKey();
        }
    }
}
