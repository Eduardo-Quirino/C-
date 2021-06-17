using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_31
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Programação n°3 ex-13. Dados três valores, A, B e C, construa um algoritmo para verificar se estes valores podem ser valores dos lados de um triângulo, e se for, se é um triângulo escaleno, um triângulo equilátero ou um triângulo isósceles.
             Se (A = B) e (B = C) => Triângulo equilátero
             Se (A = B) ou (B = C) ou (A = C) => Triângulo isósceles
             Se (A <> B) e (B <> C) e (A <> C) => Triângulo escaleno
             */

            //Entrada
            double A, B, C, p, area;
            Console.WriteLine("Checagem de 3 números passíveis de formarem um triângulo...");
            Console.WriteLine("Digite o 1º número inteiro positivo:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2º número inteiro positivo:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 3º número inteiro positivo:");
            C = Convert.ToDouble(Console.ReadLine());

            //Processamento
            if (A < B + C && B < A + C && C < A + B)
            {
                p = (A + B + C) / 2;
                area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                Console.Write(A + ", " + B + " e " + C + " formam um triângulo ");
                if (A == B && B == C) { Console.WriteLine(" EQUILÁTERO"); }
                else if (A == B || B == C || A == C) { Console.WriteLine(" ISÓSCELES"); }
                else { Console.WriteLine(" ESCALENO"); }
                Console.WriteLine("A área do triângulo vale: " + Math.Round(area, 2));
            }
            else { Console.Write(A + ", " + B + " e " + C + " NÃO formam um triângulo "); }

            //Saida
            Console.ReadKey();
        }
    }
}
