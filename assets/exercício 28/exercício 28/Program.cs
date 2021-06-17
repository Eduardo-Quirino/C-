using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_da_compra, valor_da_venda, lucro;
            Console.WriteLine("Margem de Lucro de um Produto...");
            Console.WriteLine("Digite o valor da compra do produto: ");
            valor_da_compra = Convert.ToDouble(Console.ReadLine());
            if (valor_da_compra < 10) { lucro = 0.70 * valor_da_compra; }
            else if (valor_da_compra < 30) { lucro = 0.50 * valor_da_compra; }
            else if (valor_da_compra < 50) { lucro = 0.40 * valor_da_compra; }
            else { lucro = 0.30 * valor_da_compra; }
            valor_da_venda = valor_da_compra + lucro;
            Console.WriteLine("Valor de venda do produto = R$ " + Math.Round(valor_da_venda, 2));

            Console.ReadKey();
        }
    }
}
