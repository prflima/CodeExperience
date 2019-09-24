using System;

namespace Cadastro_de_Produtos_com_FOr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produtos com FOR");

            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];


            for(int i = 0; i < produtoPreco.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º produto");
                produtoNome[i] = Console.ReadLine();

                Console.WriteLine("Digite o preço: ");
                produtoPreco[i] = double.Parse(Console.ReadLine());
            }

            foreach(var item in produtoNome)
            {
                Console.WriteLine($"Produto: {item}");
            }
        }
    }
}
