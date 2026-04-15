/* Exercício 5 — Contando Pares e Ímpares
Crie um array de 10 inteiros. Percorra o array e conte quantos números são pares e quantos são ímpares.*/

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int pares = 0;
int impares = 0;

foreach (int num in numeros)
{
    if (num % 2 == 0)
        pares++;
    else
        impares++;
}

Console.WriteLine($"Pares: {pares}");
Console.WriteLine($"Ímpares: {impares}");