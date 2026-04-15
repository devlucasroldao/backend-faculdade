/* Exercício 4 — Inversão Manual
Dado o array string[] palavras = { "C#", "é", "muito", "legal" };, exiba os elementos na ordem inversa,
sem usar Array.Reverse().

Saída esperada:
legal muito é C#*/

string[] palavras = { "C#", "é", "muito", "legal" };

for (int i = palavras.Length - 1; i >= 0; i--)
{
    Console.Write(palavras[i] + " ");
}