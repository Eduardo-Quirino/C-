using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          &&(E/END)
             (V) (V) => true
             (F) (V) => false
             (V) (F) => false
             (F) (F) => false


         ||(OU/OR)
             (V) (V) => true
             (V) (F) => true
             (F) (V) => true
             (F) (F) => false
              */
            //Entrada
            int a = 10;
            int b = 20;
            int c = 200;

            //Processamento
            if //SE
                (a<b && a>c)//Trocar aqui para && / ||
            {
                Console.WriteLine("É verdadeiro!");
            }
            else if//MAIS SE
                   (a > c){
                Console.WriteLine("Executou IF ELSE!");
                    }
            else //SE NÃO
            {
                Console.WriteLine("É Falso!");
            }

            //Saida
            Console.ReadLine();
        }
    }
}
