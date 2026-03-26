namespace EX004_heranca;

public class Conta
{
    public void AbrirConta(Pessoa pessoa)
    {
        Console.WriteLine($"Abrir conta de {pessoa.nome}:");
    }
}