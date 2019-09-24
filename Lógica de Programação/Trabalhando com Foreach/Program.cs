using System;

namespace Trabalhando_com_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            nomes[0] = "Paulo Ricardo";
            nomes[1] = "Ana Helena";
            nomes[2] = "Ronaldo";

            foreach(var item in nomes)
            {
                if(!string.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }

            int[] numeros = new int[5];
            numeros[0] = 10;
            numeros[1] = 2;
            numeros[2] = 5;

            foreach(var item in numeros)
            {
                if(item != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
