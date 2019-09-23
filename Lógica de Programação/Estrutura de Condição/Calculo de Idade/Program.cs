using System;

namespace Calculo_de_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora de idade");

            Console.WriteLine("Digite sua idade?");
            int idade = int.Parse(Console.ReadLine());

            // Calculo de Meses por idade
            int meses = idade * 12;

            // Calculo de dias por idade

            int dias = idade * 365;

            // Calculo de horas por idade

            int horas = idade * (24*365);

            // Calculo de minutos por idade

            int minutos = idade * (365 * (60*24));


            Console.WriteLine($"Sua idade corresponde a {meses} meses, {dias} dias, {horas} horas e {minutos} minutos ");
        }
    }
}
