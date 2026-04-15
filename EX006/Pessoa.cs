namespace EX006;

public class Pessoa
{
    public int Idade { get; set; }

    public string Nome { get; set; } = ""; //usando o prop
    
    public string Cpf { get; private set; }

    public DateTime DataNascimento { get;}

    /* private int idade; // campo privado

    public int Idade; // propery (com letra maíuscula por converção)
    {
        get
        {
            return idade;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Idade inválida");
            }
        } else
        {
            idade = value;
        }
    }
    // public int Idade;
    /* private int Idade;

    public int GetIdade()
    {
        return Idade;
    }

    public void SetIdade(int idade)
    {
        if (idade < 0)
        {
            Console.WriteLine("Idade invalida");
        }
        else
        {
            Idade = idade;
        }
    } */
}