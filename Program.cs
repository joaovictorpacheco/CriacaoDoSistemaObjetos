using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do Aluno:");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o Curso do Aluno:");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Digite o RG do Aluno");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("Digite a idade do Aluno:");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média final do Aluno:");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade:");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o Aluno é bolsista: s/n");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
                aluno.bolsista = true;
            }else{
                aluno.bolsista = false;
            }

            //Menu
            int opcao = 0;
            do
            {
                System.Console.WriteLine("Selecione uma opção");
                System.Console.WriteLine("[1] - Ver Média do Aluno");
                System.Console.WriteLine("[2] - Ver mensalidade do Aluno");
                System.Console.WriteLine("[3] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                    break;
                    case 2:
                    Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno.VerMensalidade()}");
                    break;
                    case 0:
                    Console.WriteLine("Obrigado por acessar!");
                    break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }
            } while (opcao !=0);
        }
    }
}
