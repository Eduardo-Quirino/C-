using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Crie um algoritimo que leia uma determinada quantidade de chuva dad em polegadas, e imprimir o seu equivalente em milímitros.
            OBS: Sabemos que 1 pol = 25.4 mm
          */

           //ENTADA
            double pol, milim;//variável do tipo real
            Console.WriteLine("Conversão de Polegadas a Milímetros");//informa o tipo do programa 
            Console.WriteLine("Digite o valor, em polegadas: (Exemplo: 2.4 ou 5... )");//pede informação no console
            pol = Convert.ToDouble(Console.ReadLine());//converte STRING para tipo de variável usada
            
            //PROCESSAMENTO
            milim = pol * 25.4;//calculo passado no exercício
            Console.WriteLine(pol + " pol. = " + milim + " mm.");//imprime no console
            
            //SAIDA
            Console.ReadKey();//permite que console fique aberto até precionar ENTER


        }
    }
}
