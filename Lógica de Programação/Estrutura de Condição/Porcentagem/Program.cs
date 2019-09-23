using System;

namespace Porcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço da mercadoria");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a quantidade de acréscimo para o percentual. OBS: não utilize o %");
            float percentual = float.Parse(Console.ReadLine());

            float acrescimo = preco * (percentual/100);

            float novopreco = preco + acrescimo;

            Console.WriteLine($"O preço foi de: {preco} para {novopreco} devido ao acréscimo de {percentual}%");
        }
    }
}
