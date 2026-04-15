/* Exercício 3 — Maior e Menor
Crie um array de 8 inteiros com valores variados. Percorra o array e encontre o maior e o menor valor,
sem usar métodos prontos como Max() ou Min(). */

int[] numeros = { 5, 2, 9, 1, 7, 3, 8, 4 };

int maior = numeros[0];
int menor = numeros[0];

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > maior)
        maior = numeros[i];

    if (numeros[i] < menor)
        menor = numeros[i];
}

Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");