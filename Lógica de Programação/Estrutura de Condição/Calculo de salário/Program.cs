using System;

namespace Calculo_de_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo!!");
            Console.WriteLine("Por favor, digite o nome do funcionário:");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Por favor, agora informe o salário desse funcionário");
            float salarioFuncionario = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o número correspondente ao cargo do funcionário:");
            Console.WriteLine(" 1 - Escriturário"); // 50% de aumento
            Console.WriteLine(" 2 - Secretário"); // 35% de aumento
            Console.WriteLine(" 3 - Caixa"); // 20% de aumento
            Console.WriteLine(" 4 - Gerente"); // 10% de aumento
            Console.WriteLine(" 5 - Diretor"); // Não tem aumento

            int opcao = int.Parse(Console.ReadLine());

            float aumento;
            float novoSalario;

            switch(opcao)
            {
                case 1:
                    aumento = salarioFuncionario * 50 / 100;
                    novoSalario = salarioFuncionario + aumento;
                    Console.WriteLine($"O funcionário {nomeFuncionario} recebeu um aumento de 50%, seu salário passou de: R$ {salarioFuncionario} para  R$ {novoSalario}");
                    break;
                
                case 2:
                    aumento = salarioFuncionario * 35 / 100;
                    novoSalario = salarioFuncionario + aumento;
                    Console.WriteLine($"O funcionário {nomeFuncionario} recebeu um aumento de 35%, seu salário passou de: R$ {salarioFuncionario} para  R$ {novoSalario}");
                    break;
                
                case 3:
                    aumento = salarioFuncionario * 20 / 100;
                    novoSalario = salarioFuncionario + aumento;
                    Console.WriteLine($"O funcionário {nomeFuncionario} recebeu um aumento de 20%, seu salário passou de: R$ {salarioFuncionario} para  R$ {novoSalario}");
                    break;
                
                case 4:
                    aumento = salarioFuncionario * 10 / 100;
                    novoSalario = salarioFuncionario + aumento;
                    Console.WriteLine($"O funcionário {nomeFuncionario} recebeu um aumento de 10%, seu salário passou de: R$ {salarioFuncionario} para  R$ {novoSalario}");
                    break;
                
                case 5:
                    Console.WriteLine("Não há aumentos para esse cargo!");
                    break;
                
                default:    
                    Console.WriteLine("Por favor digite umas das opções informadas!");
                    break;
            }
        }
    }
}
