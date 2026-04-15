/* Exercício 10 — Ordenação e Busca
Crie uma List<int> com 8 números desordenados. Faça o seguinte:

Exiba a lista original
Ordene com Sort()
Exiba a lista ordenada
Peça ao usuário um número e use IndexOf() para informar a posição dele, ou dizer que não existe na lista */

List<int> numeros = new List<int> { 8, 3, 1, 9, 5, 2, 7, 4 };

Console.WriteLine("Lista original:");
foreach (var n in numeros)
    Console.Write(n + " ");

numeros.Sort();

Console.WriteLine("\nLista ordenada:");
foreach (var n in numeros)
    Console.Write(n + " ");

Console.Write("\nDigite um número: ");
int busca = int.Parse(Console.ReadLine());

int posicao = numeros.IndexOf(busca);

if (posicao != -1)
    Console.WriteLine($"Está na posição: {posicao}");
else
    Console.WriteLine("Número não encontrado.");