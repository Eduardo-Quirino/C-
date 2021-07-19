using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_100
{
    class Program
    {
        static void bascara(double a, double b, double c)
        {
            double delta, x1, x2;
            delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Há duas raizes, iguais a: " + x1 + " e " + x2);
            }
            else if (delta == 0) { Console.WriteLine("Há apenas uma raiz: " + -b / (2 * a)); }
            else { Console.WriteLine("Não existem raizes reais para a equação..."); }
        }
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("Equação de 2º Grau - ax² + bx + c = 0 - Fórmula de Báscara");
            Console.WriteLine("Digite o valor de a: ");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            B = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            C = Double.Parse(Console.ReadLine());
            bascara(A, B, C);
            Console.WriteLine("Pressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
