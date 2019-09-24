using System;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[10];
            float[] preco = new float [10];

            float somatoria = 0;
            int opcao = 0;

            int contador = 0;
            string opcaoCadastro = "";

            do
            {
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar todos os produtos");
                Console.WriteLine("3 - Calcular a soma dos preços dos produtos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());


                // Vai escolher dentro de uma dessas opções!              
                switch(opcao) 
                {
                    case 1:
                        Console.WriteLine("Bem vindo a pagína de cadastro");
                        do // para colocar as funções do menu.
                        {
                            if(contador < 10) // Se a opção for verdadeira faça isso:
                            {
                                Console.WriteLine($"Digite o nome do {contador+1}º Produto:");
                                produto[contador] = Console.ReadLine();

                                Console.WriteLine($"Digite o Preço do {contador+1}º Produto:");  
                                preco[contador] = float.Parse(Console.ReadLine());

                                Console.WriteLine("Deseja cadastrar outro produto ? S/N");
                                opcaoCadastro = Console.ReadLine().ToUpper();
                                
                                contador++;
                            }
                            else // Se a opção for falsa, ela executa está parte (bloco)
                            {
                                Console.WriteLine("Número de produtos cadastrados foi excedido");
                            }
                            
                        } while (opcaoCadastro == "S"); // Toda a condição for verdadeira, ela irá repetir o laço. (repete tudo que está no DO)
                        break;
                    
                    case 2:
                        Console.WriteLine("Listagem de Produts");

                        int contagem = 0;

                        while (contagem < 10)
                        {
                            if(string.IsNullOrEmpty(produto[contagem]))
                            {

                                contagem = 10;
                            }
                            else
                            {
                                Console.WriteLine($"{contagem+1} - {produto[contagem]} Preço: R$ {preco[contagem]}");

                                contagem++;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Preço total");
                        
                        int contadorb = 0;
                        while(contadorb < 10)
                        {   
                            somatoria += preco[contadorb];

                            contadorb++;
                        }

                        Console.WriteLine($"O preço total dos seus produtos é de: R$ {somatoria}");
                        break;

                    default:
                        Console.WriteLine("Por favor selecione uma das opções listadas!");
                        break;
                }
                
            } while (opcao != 0);
        }
    }
}
