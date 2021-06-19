using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programação n°2
             Crie um algoritimo que leia o raio e a altura de um cilindro e que calcule e escreva o seu volume e sua área
             volume = π * raio² * altura
             area = 2 * π * (altura + raio) 
             OBS: considere  π = 3.14
             */

            //ENTRADA
            double raio, altura, volume, area;
            Console.WriteLine("Calculo de Raio e area de um CILINDRO");
            Console.WriteLine("Digite o Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            //PROCESSAMENTO

            volume = Math.PI * Math.Pow(raio,2) * altura;// Math.PI--> calcula direto o valor de PI pelo c# --> Math.Pow==> Retorna um número especificado elevado à potência especificada.
            Console.WriteLine("O volume do cilindro é: " + Math.Round(volume, 2));

            area = 2 * Math.PI*(altura+raio);// Math.PI--> calcula direto o valor de PI pelo c#
            Console.WriteLine("A área do cilindro é: " + Math.Round(area,2));


            //SAIDA
            Console.ReadKey();
        }
    }
}
