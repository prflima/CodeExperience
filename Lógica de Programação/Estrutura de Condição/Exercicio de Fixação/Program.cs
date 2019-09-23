using System;

namespace Exercicio_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo, irei calcular seu salário mensal:");
            Console.WriteLine("Digite o nome do funcionário:");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Por favor, digite o valor do salário mínimo:");
            float salarioMinimo = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite a quantidade de horas trabalhadas:");
            double horasTrabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite a quantidade de dependentes do funcionário:");
            int dependentesFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite a quantidade de horas extras trabalhadas:");
            double horasExtras = double.Parse(Console.ReadLine());


        }
    }
}
