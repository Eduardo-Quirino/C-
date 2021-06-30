using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_74
{
    class Program
    {
        static void Main(string[] args)
        {//Vetores 1° parte
            //ENTRADA
            int i, contador_de_pares = 0;
            int[] vet = new int[10];
            Console.WriteLine("Vetor de 10 inteiros - exibição dos números pares...");
            Console.WriteLine("LEITURA DO VETOR...");

            //PROCESSAMENTO
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite vet[" + i + "]: ");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0) { contador_de_pares++; }
            }
            Console.Clear();
            Console.WriteLine("VETOR ORIGINAL NA TELA:\n");
            for (i = 0; i < 10; i++) { Console.Write(vet[i] + "\t"); }
            if (contador_de_pares > 0)
            {
                Console.WriteLine("\n\nNúmeros Pares do Vetor:\n");
                for (i = 0; i < 10; i++)
                {
                    if (vet[i] % 2 == 0) { Console.Write(vet[i] + "\t"); }
                }
            }
            else { Console.WriteLine("Não foram digitados números pares no vetor!!"); }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");

            //SAIDA
            Console.ReadKey();
        }
    }
}
