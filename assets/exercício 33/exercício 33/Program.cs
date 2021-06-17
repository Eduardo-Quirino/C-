using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Programação n° 3
             Ex-15. Faça um algoritmo que receba três números e mostre-os em ordem crescente. Suponha que o usuário digitará três números diferentes.
            Se (n1 < n2) e (n2 < n3) => Ordem Crescente: n1,n2,n3 Se (n1 < n3) e (n3 < n2) => Ordem Crescente: n1,n3,n2 Se (n2 < n1) e (n1 < n3) => Ordem Crescente: n2,n1,n3 Se (n2 < n3) e (n3 < n1) => Ordem Crescente: n2,n3,n1 Se (n3 < n1) e (n1 < n2) => Ordem Crescente: n3,n1,n2 Se (n3 < n2) e (n2 < n1) => Ordem Crescente: n3,n2,n1
             */

            //Entrada
            int n1, n2, n3;
                Console.WriteLine("Ordenação de Três Números (Ordem Crescente): ");
                Console.WriteLine("Digite o 1º número inteiro positivo: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 2º número inteiro positivo: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 3º número inteiro positivo: ");
                n3 = Convert.ToInt32(Console.ReadLine());

            //Processamento
              if (n1 == n2 || n2 == n3 || n1 == n3)
                {
                    Console.WriteLine("Os três números são IGUAIS: " + n1 + " - " + n2 + " - " + n3);
                }               
                //Ordenando os três números diferentes entre si
                Console.WriteLine("Números Ordenados em Ordem Crescente:");
                if (n1 < n2 && n2 < n3) { Console.WriteLine(n1 + " - " + n2 + " - " + n3); }
                if (n1 < n3 && n3 < n2) { Console.WriteLine(n1 + " - " + n3 + " - " + n2); }
                if (n2 < n1 && n1 < n3) { Console.WriteLine(n2 + " - " + n1 + " - " + n3); }
                if (n2 < n3 && n3 < n1) { Console.WriteLine(n2 + " - " + n3 + " - " + n1); }
                if (n3 < n1 && n1 < n2) { Console.WriteLine(n3 + " - " + n1 + " - " + n2); }
                if (n3 < n2 && n2 < n1) { Console.WriteLine(n3 + " - " + n2 + " - " + n1); }

                //Saida
                Console.ReadKey();
            }

        }
    }

