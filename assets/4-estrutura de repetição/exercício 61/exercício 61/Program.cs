using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_61
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, media_multiplos_de_3, cont_multiplos_de_3 = 0, soma_multiplos_de_3 = 0;
            Console.WriteLine("Vários números - ocorrência de múltiplos de 3");
            Console.WriteLine("Digite um nº positivo ou 0 para terminar: ");
            num = Double.Parse(Console.ReadLine());
            while (num > 0)
            {
                if (num % 3 == 0)
                {
                    //cont_multiplos_de_3 = cont_multiplos_de_3 + 1;
                    cont_multiplos_de_3++;
                    //soma_multiplos_de_3 = soma_multiplos_de_3 + num;
                    soma_multiplos_de_3 += num;
                }
                Console.WriteLine("Digite um nº positivo ou 0 para terminar: ");
                num = Double.Parse(Console.ReadLine());
            }
            media_multiplos_de_3 = soma_multiplos_de_3 / cont_multiplos_de_3;
            Console.WriteLine("Quantidade de múltiplos de 3: " + cont_multiplos_de_3);
            Console.WriteLine("Soma dos múltiplos de 3: " + soma_multiplos_de_3);
            Console.WriteLine("Média dos múltiplos de 3 = " + media_multiplos_de_3);

            Console.ReadKey();
        }
    }
}
