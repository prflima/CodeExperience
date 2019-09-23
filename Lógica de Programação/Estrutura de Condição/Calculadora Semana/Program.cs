using System;

namespace Calculadora_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora semanal");
            Console.WriteLine("Qual o ano do seu nascimento?");
            int anonascimento = int.Parse(Console.ReadLine());

            int anoatual = DateTime.Now.Year;
            
            int idade = anoatual - anonascimento;

            int semanas = idade * 52;

            Console.WriteLine($"Você tem {idade} anos, isso convertido para semanas da um total de {semanas} semanas");
        }
    }
}
