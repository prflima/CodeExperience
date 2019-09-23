using System;

namespace Vetores_e_Laços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao seu programa de lista de compras");

            string[] produtos = new string[6];

            string[] quantidade = new string[6]; 

            int contador = 0;

            while(contador < 6)
            {
                Console.WriteLine($"Digite o {contador + 1}º item da lista");
                produtos[contador] = Console.ReadLine();

                Console.WriteLine("Agora digite a quantidade ou Kg desse produto");
                quantidade[contador] = Console.ReadLine();

                contador++;
            }

            contador = 0;

            while(contador < 6)
            {
                Console.WriteLine($"{contador + 1} - {produtos[contador]} : {quantidade[contador]}");
                contador++;
            }
        }
    }
}
