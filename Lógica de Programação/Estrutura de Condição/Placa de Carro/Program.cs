using System;

namespace Placa_de_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao RodizioCar");
            Console.WriteLine("Por favor, digite a placa do seu veículo:");
            string placa = Console.ReadLine();

            string finalPlaca = placa.Substring(placa.Length-1, 1);

            if(finalPlaca == "0" || finalPlaca == "1")
            {
                Console.WriteLine($"Sua placa é: {placa}, sendo assim, o dia do seu rodizio é Segunda-Feira");
            }
            else if(finalPlaca == "2" || finalPlaca == "3")
            {
                Console.WriteLine($"Sua placa é: {placa}, sendo assim, o dia do seu rodizio é Terça-Feira");   
            }
            else if(finalPlaca == "4" || finalPlaca == "5")
            {
                Console.WriteLine($"Sua placa é: {placa}, sendo assim, o dia do seu rodizio é Quarta-Feira");
            }
            else if(finalPlaca == "6" || finalPlaca == "7")
            {
                Console.WriteLine($"Sua placa é: {placa}, sendo assim, o dia do seu rodizio é Quinta-Feira");
            }
            else if(finalPlaca == "8" || finalPlaca == "9")
            {
                Console.WriteLine($"Sua placa é: {placa}, sendo assim, o dia do seu rodizio é Sexta-Feira");
            }
            else
            {
                Console.WriteLine($"Houve algum engano, por favor corrija a placa digitada: {placa}");
            }
        }
    }
}
