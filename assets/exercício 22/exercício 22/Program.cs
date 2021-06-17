using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            double peso, altura, imc;
            Console.WriteLine("I M C - Índice de Massa Corpórea");
            Console.WriteLine("Digite o peso da pessoa, em kg: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura da pessoa, em m: ");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso / Math.Pow(altura, 2);
            if (imc < 20) { Console.WriteLine("IMC = " + Math.Round(imc, 1) + " - Abaixo do Peso"); }
            else if (imc <= 25) { Console.WriteLine("IMC = " + Math.Round(imc, 1) + " - Peso Normal"); }
            else if (imc <= 30) { Console.WriteLine("IMC = " + Math.Round(imc, 1) + " - Sobre Peso"); }
            else if (imc <= 40) { Console.WriteLine("IMC = " + Math.Round(imc, 1) + " - Obeso"); }
            else { Console.WriteLine("IMC = " + Math.Round(imc, 1) + " - Obeso Mórbido"); }
            Console.ReadKey();




        }
    }
}
