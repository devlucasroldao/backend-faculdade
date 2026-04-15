/*Exercício 15 — Sistema de Notas com Tudo Junto
Crie um sistema que use Arrays e Lists juntos:

Use um string[] fixo com os nomes de 5 disciplinas
Use uma List<double> para cada disciplina, armazenando as notas dos alunos (quantidade variável)
Calcule a média de cada disciplina
Exiba um relatório final mostrando: disciplina, quantidade de alunos, maior nota, menor nota e média
Dica: você pode usar uma List<List<double>> ou um Dictionary<string, List<double>> se quiser ir além.*/

string[] disciplinas = { "Matemática", "Português", "História", "Geografia", "Ciência" };

List<List<double>> notas = new List<List<double>>
{
    new List<double> { 7, 8, 9 },
    new List<double> { 6, 7, 8 },
    new List<double> { 5, 6, 7 },
    new List<double> { 8, 9, 10 },
    new List<double> { 7, 7, 8 }
};

for (int i = 0; i < disciplinas.Length; i++)
{
    double soma = 0;
    double maior = notas[i][0];
    double menor = notas[i][0];

    foreach (var n in notas[i])
    {
        soma += n;

        if (n > maior) maior = n;
        if (n < menor) menor = n;
    }

    double media = soma / notas[i].Count;

    Console.WriteLine($"\n{disciplinas[i]}");
    Console.WriteLine($"Alunos: {notas[i].Count}");
    Console.WriteLine($"Maior: {maior}");
    Console.WriteLine($"Menor: {menor}");
    Console.WriteLine($"Média: {media}");
}

/*Gabarito Rápido — Dicas de Resolução
Exercício	Conceitos-chave
1	Declaração de array, for, índices
2	Acumulador, Length, divisão
3	Variáveis auxiliares maior/menor, comparação em loop
4	Loop reverso: for (int i = arr.Length - 1; i >= 0; i--)
5	Operador % (módulo) para verificar par/ímpar
6	Add(), Remove(), Count, foreach
7	if dentro do foreach, duas listas de destino
8	Contains() antes de adicionar na nova lista
9	Loop while + switch ou if-else para o menu
10	Sort(), IndexOf() retorna -1 se não encontrar
11	Construtor new List<int>(array) e .ToArray()
12	List<T> com tipo personalizado, properties, cálculos
13	Cast (int), InvalidCastException, boxing/unboxing
14	char[], List<char>, Contains(), lógica de jogo
15	Combinação de arrays e listas, múltiplas médias*/