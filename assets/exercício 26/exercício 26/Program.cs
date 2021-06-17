using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_bruto, prestacao, limite;
            Console.WriteLine("Prestação de Empréstimo");
            Console.WriteLine("Digite o valor do salário bruto: ");
            salario_bruto = Convert.ToDouble(Console.ReadLine());
            limite = 0.3 * salario_bruto;
            Console.WriteLine("Digite o valor da prestação que deseja pagar:: ");
            prestacao = Convert.ToDouble(Console.ReadLine());
            if (prestacao <= limite) { Console.WriteLine("Prestação de R$ " + Math.Round(prestacao, 2) + " - Empréstimo aprovado!"); }
            else { Console.WriteLine("Empréstimo negado - acima do teto!!"); }
            Console.ReadKey();

        }
    }
}
