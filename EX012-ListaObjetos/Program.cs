/* Exercício 12 — List de Objetos
Crie uma classe Produto com as properties Nome (string), Preco (double) e Quantidade (int). Depois:

Crie uma List<Produto> com pelo menos 5 produtos
Exiba todos os produtos
Calcule o valor total do estoque (preço × quantidade de cada produto)
Encontre o produto mais caro
Encontre o produto com menor estoque */

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
}

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Mouse", Preco = 50, Quantidade = 10 },
    new Produto { Nome = "Teclado", Preco = 100, Quantidade = 5 },
    new Produto { Nome = "Monitor", Preco = 800, Quantidade = 2 },
    new Produto { Nome = "Notebook", Preco = 3000, Quantidade = 1 },
    new Produto { Nome = "Fone", Preco = 150, Quantidade = 8 }
};

double total = 0;
Produto maisCaro = produtos[0];
Produto menorEstoque = produtos[0];

foreach (var p in produtos)
{
    Console.WriteLine($"{p.Nome} - R${p.Preco} - Qtd: {p.Quantidade}");

    total += p.Preco * p.Quantidade;

    if (p.Preco > maisCaro.Preco)
        maisCaro = p;

    if (p.Quantidade < menorEstoque.Quantidade)
        menorEstoque = p;
}

Console.WriteLine($"Valor total: {total}");
Console.WriteLine($"Mais caro: {maisCaro.Nome}");
Console.WriteLine($"Menor estoque: {menorEstoque.Nome}");