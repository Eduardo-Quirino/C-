using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercício_34
{
    class Program
    {
        static void Main(string[] args)
        {

            //ENTRADA
            double custo_de_fabrica, custo_consumidor, porc_impostos, por_distribuidor;
            Console.WriteLine("Cálculo do Preço Final de um Automovel");
            Console.WriteLine("Digite o custo de fábrica do carro, em R$: ");
            custo_de_fabrica = Convert.ToDouble(Console.ReadLine());


            //PROCESSAMENTO
            if (custo_de_fabrica <= 33000) 
            {
                por_distribuidor = 0.05 * custo_de_fabrica;
                porc_impostos = 0;
            }
            else if (custo_de_fabrica <=66000) 
            {
                por_distribuidor = 0.10 * custo_de_fabrica;
                porc_impostos = 0.15;
            }
            else
            {
                por_distribuidor = 0.15 * custo_de_fabrica;
                porc_impostos = 0.20 * custo_de_fabrica;
            }
            custo_consumidor = custo_de_fabrica + por_distribuidor + porc_impostos;
            Console.WriteLine("Custo final do automóvel: R$ " + Math.Round(custo_consumidor, 2));


            //SAIDA
            Console.ReadKey();

        }
    }
}
