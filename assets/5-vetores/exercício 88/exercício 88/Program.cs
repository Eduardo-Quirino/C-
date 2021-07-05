using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_88
{
    class Program
    {
        static void Main(string[] args)
        {/*Vetores 4° Parte*/

            //ENTRADA BUSCA SEQUENCIAL
            int i, x, contador_de_x = 0;
            int[] vetor = new int[8];
            Console.WriteLine("Busca Sequencial em um Vetor de 8 posições...");
            Console.WriteLine("LEITURA DO VETOR");

            //PROCESSAMENTO
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Digite o valor do número x a ser procurado no vetor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Impressão do vetor:\n");
            for (i = 0; i < 8; i++)
            {
                Console.Write(vetor[i] + "\t");
                if (vetor[i] == x) { contador_de_x++; }
            }
            if (contador_de_x > 0)
            {
                Console.WriteLine("\n\nO número " + x + " aparece " + contador_de_x + " vezes,");
                Console.WriteLine(" na(s) posição(ões): \n");
                for (i = 0; i < 8; i++) { if (vetor[i] == x) { Console.Write(i + "\t"); } }
            }
            else { Console.WriteLine("\n\nNão há ocorrências do número " + x + " no vetor"); }

            //SAIDA
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
