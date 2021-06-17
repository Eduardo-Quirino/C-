using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercício_32
{
    class Program
    {
        static void Main(string[] args)
        /*Programação n° 3 --> ex 14. Recomendam-se estudantes para bolsas de estudo em função de seu desempenho anterior. A natureza das recomendações é baseada na seguinte tabela:*/
        {
            //Entrada
            string nome;
            double media;
            Console.WriteLine("Recomendação de Bolsa para Alunos");
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a média obtida por " + nome + ":");
            media = Convert.ToDouble(Console.ReadLine());

            //processamento
            if (media>=9.0) 
            {
                Console.WriteLine((nome+" é ALTAMENTE recomendado... "));
            }
            else if (media >=8) 
            {
                Console.WriteLine(nome+" é FORTEMENTE recomendado...");
            }
            else if (media >= 7) 
            {
                Console.WriteLine(nome+" É RECOMENDADO(a)...");
            }
            else
            {
                Console.WriteLine(nome+" É NÃO RECOMENDADO(A)...");

            }

            //Saida
            Console.ReadKey();


        }
    }
}
