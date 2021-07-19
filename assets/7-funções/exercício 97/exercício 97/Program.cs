using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_97
{
    class Program
    {
        //{//Crie um algoritimo que rceba 3 notas e calcule a sua média, utilizando uma função
        static double media(double nota1, double nota2, double nota3){
            return (nota1 + nota2 + nota3);
        }
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Média de 3 notas - usando funções...");
            Console.WriteLine("Digite a 1° nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2° nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média das 3 notas: " + Math.Round(media(n1,n2,n3),2));
            
            Console.WriteLine("\n\nPrecione qualquer tecla para sair do programa...");
            Console.ReadKey();


        }
    }
}
