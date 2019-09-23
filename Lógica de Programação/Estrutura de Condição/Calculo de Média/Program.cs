using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de média");

            Console.WriteLine("Digite sua primeira nota inteira");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota inteira");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua terceira nota inteira");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a média de aprovação");
            int media = int.Parse(Console.ReadLine());
            
            float mediaaluno = (float)(nota1+nota2+nota3) / 3;

            if(mediaaluno >= media)
            {
                Console.WriteLine($"Parabéns você foi aprovado! Sua média foi de: {mediaaluno}");
            }
            else
            {
                Console.WriteLine($"Você foi reprovado, tente mais uma vez. Sua média foi de: {mediaaluno}");
            }
        }
    }
}
