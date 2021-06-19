using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_35
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            double x, y;
            Console.WriteLine("Digite a base do QUADRANTE");
            Console.WriteLine("Digite a abcissa (x) do ponto A");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a ordenada (y) do ponto B");
            Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            //PROCESSAMENTO
            if (x > 0 && y > 0) 
            {
                Console.WriteLine("Ponto do 1° QUADRANTE");
            }
            else if (x < 0 && y > 0) 
            {
                Console.WriteLine("Ponto do 2° QUADRANTE");
            }
            else if (x < 0 && y < 0) 
            {
                Console.WriteLine("Ponto do 3° QUADRANTE");

            }
            else if (x > 0 && y < 0) 
            {
                Console.WriteLine("Ponto do 4° QUADRANTE");
            }
            if (x == 0 && y == 0) { Console.WriteLine("Ponto na ORIGEM"); }
          else  if(x == 0 || y==0) { Console.WriteLine("Ponto está em UM DOS EIXOS"); }

            //SAIDA
            Console.ReadKey();

        }
    }
}
