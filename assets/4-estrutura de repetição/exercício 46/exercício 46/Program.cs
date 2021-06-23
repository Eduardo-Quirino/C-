using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_46
{
    class Program
    {
        static void Main(string[] args)
        {/*Estrutura de repetição 1° parte
          Ex 8 - Crie um algoritimo que faça uma tabela de conversão de polegadas para centímetros. Deseja-se que na tabela costem valores desde 1 polegadas até 40 polegadas
          Sabe-se  que 1 pol = 2.54cm
          Saida desejada:
            1 pol =  2.54cm
            2 pol = 5.08cm 
            ...
            40 pol = 101.6cm
          */

            //ENTRADA
            double pol;
            Console.WriteLine("Tabela de conversão de polegadas para centimetros (1 a 40)");

            //PROCESSAMENTO
            for(pol=1; pol<=40; pol++)
            {
                Console.WriteLine(pol+" polegadas = "+ pol*2.54 + "centímetros");
            }

            //SAIDA
            Console.ReadKey();
        }
    }
}
