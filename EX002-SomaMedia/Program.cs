/* Exercício 2 — Soma e Média
Crie um array com 6 valores double representando temperaturas de uma semana (sem domingo). Calcule e exiba a soma e a média das temperaturas.

Dica: use array.Length para calcular a média. */

double[] temperaturas = { 25.5, 26.0, 24.8, 23.9, 27.1, 26.3 };

double soma = 0;

for (int i = 0; i < temperaturas.Length; i++)
{
    soma += temperaturas[i];
}

double media = soma / temperaturas.Length;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Média: {media}");