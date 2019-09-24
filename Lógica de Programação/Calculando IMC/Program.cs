using System;

namespace Calculando_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o IMC de 10 Pessoas");

            string[] pessoasNome = new string[10];
            int[] pessoasIdade = new int[10];
            double[] pessoasPeso = new double[10];
            double[] pessoasAltura = new double[10];
            string[] pessoasSexo = new string[10];
            int opcaoMenu;
            int contador = 0;
            string resposta = "";
            int homens = 0;
            int mulheres = 0;
            int cadastrados = 0;
            int idadeTotalHomens = 0;
            int idadeTotalMulheres = 0;
            int mediaIdadeHomens = 0;
            int mediaIdadeMulheres = 0;
            int contagem = 0;

            do
            {


                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar uma nova pessoa");
                Console.WriteLine("2 - Listar total de cadastros e separados por sexo");
                Console.WriteLine("3 - Média de idade de cadastros masculinos");
                Console.WriteLine("4 - Média de idade de cadastros femininos");
                Console.WriteLine("5 - IMC de cada usuário cadastrado");
                Console.WriteLine("0 - Sair");
                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {

                    case 1:
                        do
                        {

                            Console.WriteLine("Informe seu nome:");
                            pessoasNome[contador] = Console.ReadLine();

                            Console.WriteLine("Informe sua idade:");
                            pessoasIdade[contador] = int.Parse(Console.ReadLine());

                            Console.WriteLine("Informe seu peso:");
                            pessoasPeso[contador] = double.Parse(Console.ReadLine());

                            Console.WriteLine("Informe sua altura");
                            pessoasAltura[contador] = double.Parse(Console.ReadLine().Replace('.',','));

                            Console.WriteLine("Selecione o seu sexo:  M - Masculino e F - Feminino");
                            pessoasSexo[contador] = Console.ReadLine().ToUpper();

                            Console.WriteLine("Deseja Calcular Cadastrar outra pessoa? S/N");
                            resposta = Console.ReadLine().ToUpper();

                            if(pessoasSexo[contador] == "F")
                            {
                                mulheres++;
                            }
                            else if(pessoasSexo[contador] == "M")
                            {
                                homens++;
                            }

                            if(resposta == "S" || resposta == "N")
                            {
                                contador++;
                            }

                            cadastrados++;               

                        } while (resposta == "S"); 
                        break;

                    case 2:

                        Console.WriteLine($"Total de Pessoas cadastradas é: {cadastrados}");
                        Console.WriteLine($"Total de Mulheres cadastradas é: {mulheres}");
                        Console.WriteLine($"Total de Homens cadastrados é: {homens}");

                        break;
                    
                    case 3:

                        foreach(var sexo in pessoasSexo)
                        {
                            if(!string.IsNullOrEmpty(sexo))
                            {
                                if(sexo == "F")
                                {
                                    idadeTotalMulheres += pessoasIdade[contagem];
                                }
                                else if(sexo == "M")
                                {
                                    idadeTotalHomens += pessoasIdade[contagem];
                                }
                            }

                            contagem++;
                        }
                        
                        mediaIdadeHomens = idadeTotalHomens / homens;

                        Console.WriteLine($"A média de idade dos homens cadastrados é de: {mediaIdadeHomens}");
                        break;
                    
                    case 4:

                        mediaIdadeMulheres = idadeTotalMulheres / mulheres;

                        Console.WriteLine($"A média de idade das mulheres cadastradas é de: {mediaIdadeMulheres}");
                        break;
                    
                    case 5:
                        
                        for(int i = 0; i < pessoasNome.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(pessoasNome[i]))
                            {
                                double imc = 0;
                                imc = pessoasPeso[i] / (pessoasAltura[i] * pessoasAltura[i]);

                                Console.WriteLine($"O IMC do usuário {pessoasNome[i]} é: {imc}");
                            }
                        }
                        break;
                }
            } while (opcaoMenu != 0);
        }
    }
}
