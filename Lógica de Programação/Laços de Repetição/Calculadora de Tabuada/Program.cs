using System;

namespace Calculadora_de_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Essa é a sua tabuada, seja bem-vindo!");

            Console.WriteLine("Digite um número no qual deseja saber a tabuada:");
            int numero = int.Parse(Console.ReadLine());

            int multiplicador = 1;

            while(multiplicador < 11)
            {
                int resultado = numero * multiplicador;
                Console.WriteLine($"{numero} X {multiplicador} = {resultado}");

                multiplicador++;
            }
        }
    }
}
