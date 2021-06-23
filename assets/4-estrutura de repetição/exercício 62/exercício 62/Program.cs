using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_62
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma=0,contador=0, media;
            Console.WriteLine("Vários números - Cálculos diversos");
            Console.WriteLine("Digite um n° positivo, ou 0 para PARAR");
            num = double.Parse(Console.ReadLine());
            while (num>0) {
                soma += num;
                contador++;
                Console.WriteLine("Digite um n° positivo, ou 0 para PARAR");
                num = double.Parse(Console.ReadLine());
            }
            media = soma / contador;
            Console.WriteLine("A soma dos números digitados foi: "+soma);
            Console.WriteLine("A quantidade de números digitados foi: "+ contador);
            Console.WriteLine("A média dos números digitados foi: "+ Math.Round(media,2));

            Console.ReadKey();
        }
    }
}
