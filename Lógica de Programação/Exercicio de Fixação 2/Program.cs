using System;

namespace Exercicio_de_Fixação_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo!");

            float[] nota1 = new float[10];
            float[] nota2 =  new float[10];
            float[] mediaAluno = new float[10];
            float somatoria = 0;
            int contador = 0;
            float mediaClasse = 0;
            int qtdAprovados = 0;
            int qtdReprovados = 0;


            while(contador < 10)
            {
                Console.WriteLine($"Digite a 1º nota do {contador + 1}º Aluno:");
                nota1[contador] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a 2º nota do {contador + 1}º Aluno:");
                nota2[contador] = float.Parse(Console.ReadLine());

                somatoria += nota1[contador] + nota2[contador];

                mediaClasse = somatoria / 10;

                mediaAluno[contador] = (nota1[contador] + nota2[contador]) / 2;

                if(mediaAluno[contador] >= 7)
                {
                    qtdAprovados++;
                }
                else
                {
                    qtdReprovados++;
                }

                contador++;
            }

            Console.WriteLine($"A média da classe é de: {mediaClasse}");
            Console.WriteLine($"A Quantidade de Alunos APROVADOS é de: {qtdAprovados}");
            Console.WriteLine($"A Quantidade de Alunos REPROVADOS é de: {qtdReprovados}");
        }
    }
}
