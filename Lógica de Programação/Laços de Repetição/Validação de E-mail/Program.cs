using System;

namespace Validação_de_E_mail
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
 

            do
            {
                
            Console.WriteLine("Por favor, digite seu e-mail:");
            email = Console.ReadLine();

            }while(!email.Contains("@") || !email.Contains("."));         

            string senha;

            do{
                Console.WriteLine("Por favor, digite sua senha? OBS: Mínimo 6 digitos");
                senha = Console.ReadLine();
            }while(senha.Length < 6);
        }
    }
}
