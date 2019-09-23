using System;

namespace Agência_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");

            string[] nome = new string[3];
            string[] origem = new string[3];
            string[] destino = new string[3];
            DateTime[] dataVoo = new DateTime[3];
            int opcao = 0;
            int contador = 0;
            string opcaoCadastro = "";

            do
            {
                Console.WriteLine("Selecione uma oção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar nosso sistema!");
                        break;

                    case 1:
                        Console.WriteLine("Bem vindo a página de cadastro");

                        do
                        {

                            if (contador <= 3)
                            {
                                Console.WriteLine("Digite seu nome:");
                                nome[contador] = Console.ReadLine();

                                Console.WriteLine("Digite a origem do vôo");
                                origem[contador] = Console.ReadLine();

                                Console.WriteLine("Qual é o destino?");
                                destino[contador] = Console.ReadLine();

                                Console.WriteLine("Qual a data da viagem?");
                                dataVoo[contador] = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Deseja cadastrar um novo usuário? S/N");
                                opcaoCadastro = Console.ReadLine().ToUpper();

                                contador++;
                            }
                            else
                            {
                                Console.WriteLine("Número de Passagens excedidas");
                                break;
                            }
                        } while (opcaoCadastro == "S");
                        break;

                    case 2:
                        Console.WriteLine("Listando as Passagens");

                        int contagem = 0;

                        while(contagem < 3){
                            Console.WriteLine($"Nome Passageiro: {nome[contagem]}     Data Partida: {dataVoo[contagem]}");
                            Console.WriteLine($"Origem: {origem[contagem]}       Destino: {destino[contagem]}");

                            contagem++;
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
