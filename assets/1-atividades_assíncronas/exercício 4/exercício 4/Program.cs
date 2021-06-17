using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programação n° 1
             Ex-4. Crie um algoritmo que leia o valor do raio de uma esfera e calcule e mostre na tela:
            - O seu comprimento (C = 2*π*R)
            - A sua área (A = π*R²)
            - O seu volume (V = (4/3)* π*R³)
             */

            //ENTRADA
            double R, comp, area, volume;
            Console.WriteLine("Valores notáveis de uma esfera");
            Console.WriteLine("Digite o valor do raio da esfera: ");//pede para digitar no console
            R = Convert.ToDouble(Console.ReadLine());//recebe o valor digitado no console

            //PROCESSAMENTO
            comp = 2 * Math.PI * R;//informa o valor exato de PI
            area = Math.PI * Math.Pow(R, 2);//Math.Pow(x,y)--> é o mesmo que dizer R²
            volume = (4/3) * Math.PI * Math.Pow(R,3);//Math.Pow(x,y)--> é o mesmo que dizer R³
            Console.WriteLine("Comprimento = " +Math.Round(comp,2) );//Math.Round(comp,2)-->resultado com duas casas decimais
            Console.WriteLine("Área = " + Math.Round(area,2));//Math.Round(comp,2)-->resultado com duas casas decimais
            Console.WriteLine("Volume = " + Math.Round(volume,2));//Math.Round(comp,2)-->resultado com duas casas decimais


            //SAIDA
            Console.ReadKey();

        }
    }
}
