using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12. Dados três valores, A, B e C, construa um algoritmo para verificar se estes valores podem ser valores dos lados de um triângulo.
             A, B e C formam um triângulo <=> A < (B+C) e B < (A + C) e
             C < (A + B)*/

            //Entrada
            int A, B, C;
            Console.WriteLine("Checagem de 3 números passíveis de formarem um triângulo...");
            Console.WriteLine("Digite o 1º número inteiro positivo:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número inteiro positivo:");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3º número inteiro positivo:");
            C = Convert.ToInt32(Console.ReadLine());

            //Processamento
            if (A < B + C && B < A + C && C < A + B)
            {
                Console.WriteLine(A + ", " + B + " e " + C + " formam um triângulo....");
            }
            else
            {
                Console.WriteLine(A + ", " + B + " e " + C + " NÃO formam um triângulo....");
            }

            //Saida
            Console.ReadKey();

        }
    }
}
