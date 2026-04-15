class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

// usando
Pessoa p = new Pessoa();
p.Nome = "Lucas";
p.Idade = 20;
p.Apresentar();