using System;

namespace Média_e_Falta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao app Calculo de Média e Faltas");

            Console.WriteLine("Digite a primeira nota:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a quantidade de faltas:");
            int falta = int.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;


            bool mediaAprovado = true;
            bool faltaAprovado = true;

            bool verdadeiro = true;
            bool falso = false;

            if(media >= 50)
            {
                mediaAprovado = true;
            }
            else
            {
                mediaAprovado = false;
            }


            if(falta <= 30)
            {
                faltaAprovado = true;
            }
            else
            {
                faltaAprovado = false;
            }


            if(faltaAprovado && mediaAprovado)
            {
                Console.WriteLine($"Parabéns, você foi aprovado!!! Essa é a sua média: {media}, e seu total de falta de: {falta}");
            }
            else if(faltaAprovado == falso && mediaAprovado == verdadeiro)
            {
                Console.WriteLine($"Infelizmente você foi reprovado por falta! Mesmo com a média de: {media}, você reprovou por faltas com o total de: {falta}");
            }
            else if(mediaAprovado == falso && faltaAprovado == verdadeiro)
            {
                Console.WriteLine($"Você foi reprovado por média! Infelizmente sua média ficou abaixo do solicitado! Média de: {media}");
            }
            else if(mediaAprovado == falso && faltaAprovado == falso)
            {
                 Console.WriteLine($"Infelizmente você foi reprovado!! Sua média foi de: {media}, e seu total de falta de: {falta}");
            }


            // Teste com operador ternário

            // Console.WriteLine("Digite sua média");
            // float media = float.Parse(Console.ReadLine());

            // float reprovado = 49;

            // bool resultado = media > reprovado ? true : false;

            // Console.WriteLine(resultado);
        }
    }
}
