using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_20
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double salario, aumento, salario_reajustado;
            Console.WriteLine("Reajuste de Salário na Empresa XPTO");
            Console.WriteLine("Digite o nome do(a) funcionário (a):");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário de " + nome + ", em R$: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario <= 2500) { aumento = 0.12 * salario; }
            else { aumento = 0.05 * salario; }
            salario_reajustado = salario + aumento;
            Console.WriteLine(nome + " terá um aumento de R$ " + Math.Round(aumento, 2));
            Console.WriteLine("O salário de " + nome + ", reajustado será de R$ " + Math.Round(salario_reajustado, 2));
            Console.ReadKey()exerc´cio 
        }
    }
}
