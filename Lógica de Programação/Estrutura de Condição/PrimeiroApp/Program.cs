using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo a calculadora de imc");
            Console.WriteLine("Digite seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine().Replace('.', ','));

            double imc = peso/(altura * altura);

            Console.WriteLine($"O seu IMC é de: {imc}");
        }
    }
}
