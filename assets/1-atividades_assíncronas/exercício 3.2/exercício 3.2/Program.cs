using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // valores notáveis
            //ENTRADA
            double R, comp, area, volume;
            Console.WriteLine("Valores notáveis de uma esfera");
            Console.WriteLine("Digite o valor do raio da esfera: ");
            R = Convert.ToDouble(Console.ReadLine());
            //Math.PI te dá o valor exato do pi
            comp = 2 * Math.PI * R;
            //Math.Pow(x,y) = x^y (Potenciação)
            area = Math.PI * Math.Pow(R, 2);
            //Math.Pow(R,2) = R²
            volume = (4 / 3) * Math.PI * Math.Pow(R, 3);
           
            //PROCESSAMENTO
            Console.WriteLine("Comprimento = " + Math.Round(comp, 2));
            Console.WriteLine("Área = " + Math.Round(area, 2));
            Console.WriteLine("Volume = " + Math.Round(volume, 2));
          
            //SAIDA
            Console.ReadKey();

        }
    }
}
