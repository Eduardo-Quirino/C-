using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um algoritimo que ache as raizes de uma equação do 2° grau: AX² + BX + C = 0,
               dica D = B² -4 A *C
            Se D < 0, não existe raiz real
            Se D = 0, x1 = x2 = B/(2 * A)
            Se D > 0
             */
            //ENTRADA
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Resolução da Equação de Segundo Grau ax² + bx + c = 0");
            Console.WriteLine("Fórmula de Báscara");
            Console.WriteLine("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;

            //PROCESSAMENTO
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Existem duas raizes na equação: " + x1 + " e " + x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Existe apenas uma raiz: " + x1);
            }
            else { Console.WriteLine("Não existem raizes reais nesta equação..."); }

            //SAIDA
            Console.ReadKey();

        }
    }
}
