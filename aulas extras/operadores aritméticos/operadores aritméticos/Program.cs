using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_aritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            int numeroQualquer = 20 + 20;//variável soma
            int numeroMul = 15 * 5;//variável multiplicação
            float numeroDiv = 5 / 2.0f;//variável divisão

            //Processamento
            Console.WriteLine("A soma de 20 + 20 é "+numeroQualquer);//mostra o resultado
            Console.WriteLine("A multiplicação de 15 * 5 é " + numeroMul);
            Console.WriteLine("A divisão entre 5 / 2 é " +numeroDiv);

            //Saida
            Console.ReadLine();//mostrar na tela do console
        }
    }
}
