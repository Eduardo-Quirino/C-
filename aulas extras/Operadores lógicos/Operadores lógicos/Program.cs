using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_lógicos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada
            Console.WriteLine("Didite sua idade! ");//imprime pergunta na tela
         int idade = int.Parse (Console. ReadLine());//recebe informação na tela
         //int.Parse => para converter

            //Processamento
            if (idade >= 0 && idade <= 11)//criança até 11 anos
            {
                Console.WriteLine("Você é uma criança! ");
            }
            else if (idade >= 12 && idade <= 17) //adolecente até 18 anos
            {
                Console.WriteLine("Voçê é um adolecente! ");
            }
            else if (idade >= 18 && idade <= 60)//adulto até 60 anos
            {
                Console.WriteLine("Você é um adulto ");//idoso
            }
            else
            {
                Console.WriteLine("Você é um Idoso!");
            }

            //Saida
            Console.ReadLine();//imprime no comsole
        }
    }
}
