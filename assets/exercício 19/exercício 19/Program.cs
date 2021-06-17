using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            double nota1, nota2, nota3, nota4, media;
            String nome;

            //processamento
            Console.WriteLine("Média de 4 notas de um aluno: ");
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a 1ª nota de " + nome + ":");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota de " + nome + ":");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 3ª nota de " + nome + ":");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 4ª nota de " + nome + ":");
            nota4 = Convert.ToDouble(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 7) { Console.WriteLine(nome + " está APROVADO, com média: " + media); }
            else { Console.WriteLine(nome + " está REPROVADO, com média: " + media); }
            
            //Saida
            Console.ReadKey();

        }
    }
}
