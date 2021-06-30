using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_70
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 3° parte
          Crie um algoritmo que leia um número inteiro positivo, determine a sua decomposição em fatores primos calculando também a multiplicidade de cada fator.
            */

            //ENTRADA
            int num, fator=2, multiplicidade;
            Console.WriteLine("Decomposição de um número em fatores primos...");
            Console.WriteLine("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            while(num>1)
            {
                multiplicidade = 0;
                while (num%fator == 0) {
                    multiplicidade++;
                    num = num / fator;
                }
                if(multiplicidade != 0)
                {
                    Console.WriteLine("Fator: " + fator + ", multiplicacidade: "+ multiplicidade);
                }
                fator++;
            }
            //SAIDA
            Console.WriteLine("Pressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
