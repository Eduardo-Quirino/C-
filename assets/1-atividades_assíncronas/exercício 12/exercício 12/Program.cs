using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {/*Programação n°2
         Ex 7 - Crie um algoritimo que leia as coordenadas de dois pontos A(A^X e A^Y) e B(X^B e Y^B) e calcule a distância entre esses dois pontos.
            
            SABE-SE QUE: AB^d = √(Xb-Xa)² + (Yb - Ya)²
          */
            //ENTRADA
            double xA, xB, yA, yB, distancia;
            Console.WriteLine("Distância entre dois pontos A e B");
            Console.WriteLine("Digite a abcissa do ponto A (xA): ");
            xA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a ordenada do ponto A (yA): ");
            yA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a abcissa do ponto B (xB): ");
            xB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a ordenada do ponto B (yB): ");
            yB = Convert.ToDouble(Console.ReadLine());

            //PROCESSAMENTO
            distancia = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            Console.WriteLine("A distância entre os pontos A e B vale: " + distancia);

            //SAIDA
            Console.ReadKey();
        }
    }
}
