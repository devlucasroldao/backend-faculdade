/* Exercício 6 — Lista de Compras
Crie um programa de lista de compras usando List<string>. O programa deve:

Começar com 3 itens já na lista
Adicionar 2 itens novos com Add()
Remover 1 item com Remove()
Exibir a lista final com foreach
Exibir a quantidade total de itens com Count */

List<string> compras = new List<string>
{
    "Arroz",
    "Feijão",
    "Leite"
};

compras.Add("Pão");
compras.Add("Carne");

compras.Remove("Feijão");

foreach (var item in compras)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total: {compras.Count}");