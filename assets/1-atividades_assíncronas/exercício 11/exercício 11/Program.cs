using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {/*Programação n° 2
         Ex 6 - Desenvolva um algoritimo para ler os comprimentos dos três lados de um triangulo(L1, L2, e L3) e calcular a área do triangulo de acordo com a formula √T*(T-L1)*(T-L2)*(T-L3) e T = (L1+L2+L3)/2
            RAIZ Q (x) = √X
         */

            //ENTRADA
            double L1, L2, L3,T, area;
            Console.WriteLine("Área de um triangulo - Fórmula de Herão");
            Console.WriteLine("Digite o valor do 1° lado do triângulo: ");
            L1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do 2° lado do triângulo: ");
            L2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do 3° lado do triângulo: ");
            L3 = Convert.ToDouble(Console.ReadLine());

            //PROCESSAMENTO
            T = ( L1 + L2 + L3) / 2;
            area = Math.Sqrt(T*(T-L1)*(T-L2)*(T-L3));//Math.Sqrt(X) é a quadrada de X
            Console.Write("A área do triangulo vale: "+area);

            //SAIDA
            Console.ReadKey();
        }
    }
}
