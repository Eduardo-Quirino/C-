using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_60._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que lê vários números e só para quando digitarmos 0
            //ou um nº negativo e contaremos quantos números foram digitados
            //e calculamos a média dos números digitados
            double num, contador = 0, soma_dos_digitados = 0, media_dos_digitados;
            Console.WriteLine("Leitura de vários números (sem saber a quantidade)...");
            Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar: ");
            num = Double.Parse(Console.ReadLine());
            while (num > 0)
            {
                contador++;
                soma_dos_digitados += num;// soma_dos_digitados = soma_dos_digitados + num;
                Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar: ");
                num = Double.Parse(Console.ReadLine());
            }
            media_dos_digitados = soma_dos_digitados / contador;
            Console.WriteLine("Foram digitados " + contador + " números...");
            Console.WriteLine("A média dos números digitados é: " + Math.Round(media_dos_digitados, 2));

            Console.ReadKey();
        }
    }
}
