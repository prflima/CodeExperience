using System;

namespace Calcule_o_Triplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            float numero = float.Parse(Console.ReadLine().Replace('.', ','));
            float resultado = numero * 3;
            Console.WriteLine($"O triplo do número digitado é: {resultado}");
        }
    }
}
