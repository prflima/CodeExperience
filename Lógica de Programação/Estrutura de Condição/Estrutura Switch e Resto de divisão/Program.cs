using System;

namespace Estrutura_Switch_e_Resto_de_divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo!!!");
            Console.WriteLine("Digite um número:");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado1 = numero1 % 2;

            float resultado2 = numero2 % 2;

            switch(resultado1)
            {
                case 1:
                    Console.WriteLine($"O primeiro número {numero1} é ímpar!");
                    break;
                
                case 0:
                    Console.WriteLine($"O primeiro número {numero2} é par!");
                    break;

                default:
                    Console.WriteLine("Verifique se você digitou os números corretamente.");
                    break;
            }

            switch(resultado2)
            {
                case 1:
                    Console.WriteLine($"O segundo número {numero2} é ímpar!");
                    break;

                case 0:
                    Console.WriteLine($"O segundo número {numero2} é par!");
                    break;
                
                default:
                    Console.WriteLine("Verifique se você digitou os números corretamente.");
                    break;
            }


            if(numero1 > numero2)
            {
                Console.WriteLine($"O número {numero1} é o maior, e o número {numero2} é o menor.");
            }
            else if(numero1 < numero2)
            {   
                Console.WriteLine($"O número {numero2} é o maior, e o número {numero1} é o menor.");
            }
            else
            {
                Console.WriteLine($"Os números {numero1} e {numero2} são iguais");
            }
        }
    }
}
