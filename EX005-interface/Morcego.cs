namespace EX005_interface;

public class Morcego : Mamifero, IVoar
{
    public void Voar()
    {
        Console.WriteLine("voar voar subir subir... tchau morcego!");
    }
}