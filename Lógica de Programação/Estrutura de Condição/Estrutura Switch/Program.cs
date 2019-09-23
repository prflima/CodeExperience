using System;

namespace Estrutura_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a SmartCalc");

            Console.WriteLine("Por Favor, digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor, Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma das operações abaixo.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("A - Soma dos 2 números.");
            Console.WriteLine("B - Subtração do primeiro pelo segundo");
            Console.WriteLine("C - Subtração do segundo pelo primeiro");
            Console.WriteLine("D - Multiplicação dos dois números");
            Console.WriteLine("E - Divisão do primeiro pelo segundo");
            Console.WriteLine("F - Divisão do segundo pelo primeiro");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Escolha uma das opções:");
            string opcao = Console.ReadLine().ToUpper();            

            switch(opcao)
            {
                case "A":
                    float soma = numero1 + numero2;
                    Console.WriteLine($"A Soma dos números é igual a: {soma}");
                    break;
                
                case "B":
                    float subtracao1 = numero1 - numero2;
                    Console.WriteLine($"A subtração do primeiro pelo segundo é igual a: {subtracao1}");
                    break;
                
                case "C":
                    float subtracao2 = numero2 - numero1;
                    Console.WriteLine($"A subtração do segundo pelo primeiro é igual a: {subtracao2}");
                    break;
                
                case "D":
                    float multiplicacao = numero1 * numero2;
                    Console.WriteLine($"A multiplicação dos números é igual a: {multiplicacao}");
                    break;

                case "E":
                    if(numero1 == 0 || numero2 == 0)
                    {
                        Console.WriteLine("Por favor, digite um número diferente de 0");
                    }
                    else
                    {
                        float divisao1 = numero1 / numero2;
                        Console.WriteLine($"O resultado da divisão do primeiro pelo segundo é igual a: {divisao1}");
                    }
                    break;
                
                case "F":
                       if(numero1 == 0 || numero2 == 0)
                    {
                        Console.WriteLine("Por favor, digite um número diferente de 0");
                    }
                    else
                    {
                        float divisao2 = numero2 / numero1;
                        Console.WriteLine($"O resultado da divisão do segundo pelo primeiro é igual a: {divisao2}");
                    }
                    break;
                
                default:
                    Console.WriteLine("Por favor selecione uma das opções válidas");
                    break;
            }
        }
    }
}
