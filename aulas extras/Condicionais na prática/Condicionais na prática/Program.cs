using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_na_prática
{
    class Program
    {
        static void Main(string[] args)
        {
            //if condicional SE
            //Entrada
            int a = 10;
            int b = 20;
            int c = 2;

            if (a < b) {
              
                //Processamento
            Console.WriteLine("É verdadeiro! ");

            }
            //else condicional SE NÂO

            else if (b != c){
                Console.WriteLine("Executou Elseif !");
            }
            //else condicional SE NÂO
            else
            {
                Console.WriteLine("É falso!");
            }

            //Saida
            Console.ReadLine();

        }
    }
}
