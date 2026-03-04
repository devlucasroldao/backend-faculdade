/* int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
} 
else
{

    Console.WriteLine("Você é menor de idade");
}

int nota = 85;

if (nota >= 90)
{
    Console.WriteLine("Aprovado com sucesso");
}
else if (nota >= 60)

{
    Console.WriteLine("Aprovado");
}

else
{
    Console.WriteLine("Reprovado");
}

string cor = "vermelho";
switch (cor)
{
    case "vermelho":
        Console.WriteLine("Essa cor é vermelha!");
        break;
    case "azul":
        Console.WriteLine("Essa cor é azul, não vermelha");
        break;
    default:
        Console.WriteLine("Cor não encontrada!");
        break;
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Contagem: {i}");
}

int contador = 0;
while (contador < 5)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;
    // contador recebe ele mesmo + 1
}

int contador = 0;

do
{
    Console.WriteLine($"Contagem {contador}");
    contador++;
} while (contador < 5); */

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
        //continue;
    }
    Console.WriteLine(i);
}