/* Exercício 14 — Jogo da Forca (simplificado)
Use um array de char para armazenar a palavra secreta e uma List<char> para armazenar as letras já tentadas. A cada rodada:

Exiba a palavra com _ para letras não descobertas
Peça uma letra ao jogador
Verifique se a letra já foi tentada (use Contains() na lista)
Verifique se a letra existe na palavra
O jogo termina quando todas as letras forem descobertas ou após 6 erros*/

string palavra = "csharp";
char[] descoberta = new string('_', palavra.Length).ToCharArray();
List<char> tentadas = new List<char>();

int erros = 0;

while (erros < 6 && new string(descoberta) != palavra)
{
    Console.WriteLine(string.Join(" ", descoberta));

    Console.Write("Digite uma letra: ");
    char letra = Console.ReadLine()[0];

    if (tentadas.Contains(letra))
    {
        Console.WriteLine("Já tentou!");
        continue;
    }

    tentadas.Add(letra);

    bool acertou = false;

    for (int i = 0; i < palavra.Length; i++)
    {
        if (palavra[i] == letra)
        {
            descoberta[i] = letra;
            acertou = true;
        }
    }

    if (!acertou)
        erros++;
}

if (erros < 6)
    Console.WriteLine("Ganhou!");
else
    Console.WriteLine("Perdeu!");