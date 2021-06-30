using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_69
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3° parte
        Crie um programa que leia 10 elementos inteiros e mostre a quantidade de números primos dentre os números que foram digitados:
            Ex:
            4
            7
            12
            5      => Existem 3 números primos
            14
            36
            16
            180
            666
            13
          */

            int i, contador_de_divisor, num, divisor, contador_de_primos = 0;
            Console.WriteLine("Dez Números - Quem é ou quem não é primo?");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o " + i + "º número positivo: ");
                num = int.Parse(Console.ReadLine());
                //As 2 instruções, acima, lêem 10 números
                //Agora, contaremos o número de divisores de cada num lido
                contador_de_divisor = 0;
                for (divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0) { contador_de_divisor++; }
                }
                if (contador_de_divisor == 2) { contador_de_primos++; }
            }
            Console.WriteLine("Existem " + contador_de_primos + " primos nessa coleção...");
            Console.WriteLine("Pressione qualquer tecla para sair do programa....");
            Console.ReadKey();
        

    }
    }
}
