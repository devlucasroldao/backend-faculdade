/* Exercício 9 — Cadastro de Alunos
Crie uma List<string> para armazenar nomes de alunos. Faça um menu interativo no console:

1 - Adicionar aluno
2 - Remover aluno
3 - Listar alunos
4 - Buscar aluno por nome
5 - Sair
Use Console.ReadLine() para capturar a entrada do usuário.*/

List<string> alunos = new List<string>();

int opcao;

do
{
    Console.WriteLine("\n1 - Adicionar aluno");
    Console.WriteLine("2 - Remover aluno");
    Console.WriteLine("3 - Listar alunos");
    Console.WriteLine("4 - Buscar aluno");
    Console.WriteLine("5 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Nome do aluno: ");
            alunos.Add(Console.ReadLine());
            break;

        case 2:
            Console.Write("Nome para remover: ");
            alunos.Remove(Console.ReadLine());
            break;

        case 3:
            foreach (var aluno in alunos)
                Console.WriteLine(aluno);
            break;

        case 4:
            Console.Write("Nome para buscar: ");
            string busca = Console.ReadLine();

            if (alunos.Contains(busca))
                Console.WriteLine("Aluno encontrado!");
            else
                Console.WriteLine("Aluno não encontrado.");
            break;

    }

} while (opcao != 5);