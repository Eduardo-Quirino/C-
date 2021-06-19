using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {/*Programação n° 2
         Ex 3 - Crie um algoritimo que leia a base e a altura de uma pirâmide e calcule e escreva o seu volume.

            volume =  base * altura / 3
         */

            //ENTRADA
            double b, altura, volume;//variável do tipo INTEIRO
            Console.WriteLine("Cálculo do Volume de uma Pirâmide");
            Console.WriteLine("Digite a área da base da pirâmide: ");//informa o tipo do programa 
            b = Convert.ToDouble(Console.ReadLine());//converte STRING para tipo da variavel
            Console.WriteLine("Digite a altura da pirâmide: ");//pergunta no console
            altura = Convert.ToDouble(Console.ReadLine());//converte STRING para tipo da variavel

            //PROCESSAMENTO
            volume = (b * altura) / 3;//dados do volume
            //volume = b * altura / 3;//outra forma==> dados do volume
            Console.WriteLine("O volume da pirâmide é: " + volume+ " m³");//imprime no comsole 
            
            //SAIDA
            Console.ReadKey();


        }
    }
}
