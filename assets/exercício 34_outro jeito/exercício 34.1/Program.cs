using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_34._1
{
    class Program
    {
        static void Main(string[] args)
        {

            double custo_de_fabrica, custo_consumidor, porc_impostos, porc_distribuidor;
            Console.WriteLine("Cálculo do Preço Final de um Automóvel");
            Console.WriteLine("Digite o custo de fábrica do carro, em R$:");
            custo_de_fabrica = Convert.ToDouble(Console.ReadLine());
            if (custo_de_fabrica <= 33000)
            {
                porc_distribuidor = 0.05 * custo_de_fabrica;
                porc_impostos = 0;
                custo_consumidor = custo_de_fabrica + porc_distribuidor + porc_impostos;
                Console.WriteLine("Custo Final do Automóvel: R$ " + Math.Round(custo_consumidor, 2));
            }
            if (custo_de_fabrica > 33000 && custo_de_fabrica <= 66000)
            {
                porc_distribuidor = 0.10 * custo_de_fabrica;
                porc_impostos = 0.15 * custo_de_fabrica;
                custo_consumidor = custo_de_fabrica + porc_distribuidor + porc_impostos;
                Console.WriteLine("Custo Final do Automóvel: R$ " + Math.Round(custo_consumidor, 2));
            }
            if (custo_de_fabrica > 66000)
            {
                porc_distribuidor = 0.15 * custo_de_fabrica;
                porc_impostos = 0.20 * custo_de_fabrica;
                custo_consumidor = custo_de_fabrica + porc_distribuidor + porc_impostos;
                Console.WriteLine("Custo Final do Automóvel: R$ " + Math.Round(custo_consumidor, 2));
            }
            Console.ReadKey();
        }
    }
}
