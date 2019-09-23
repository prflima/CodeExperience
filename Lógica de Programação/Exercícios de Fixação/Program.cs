using System;

namespace Exercícios_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo!");

            int[] idade = new int[10];

            int menor = 0;
            int maior = 0;
            int contador = 0;

            while(contador < 10)
            {
                Console.WriteLine($"Digite a idade do {contador + 1}º candidato?");
                idade[contador] = int.Parse(Console.ReadLine());

                if(idade[contador] <= 17)
                {
                    menor++;
                }
                else
                {
                    maior++;
                }

                contador ++;
            }

            Console.WriteLine($"A quantidade de pessoas menor de idade é de: {menor}.");
            Console.WriteLine($"A quantidade de pessoas maior de idade é de: {maior}.");
        }
    }
}
