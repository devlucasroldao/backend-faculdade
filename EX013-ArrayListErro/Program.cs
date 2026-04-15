/*Exercício 13 — ArrayList vs List (Demonstração de Problema)
Crie um ArrayList e adicione os seguintes valores:
10, "texto", 3.14, true. Depois, tente somar todos os valores numéricos. O objetivo é ver o problema acontecer:
o código vai compilar, mas vai gerar erros em tempo de execução. Entenda por que List<T> é melhor.

Reflexão: Anote em um comentário no código por que o ArrayList gerou erro e como List<int> evitaria esse problema.*/

using System.Collections;

ArrayList lista = new ArrayList();

lista.Add(10);
lista.Add("texto");
lista.Add(3.14);
lista.Add(true);

int soma = 0;

foreach (var item in lista)
{
    // Isso pode dar erro!
    if (item is int)
        soma += (int)item;
}

Console.WriteLine($"Soma: {soma}");

// ArrayList aceita qualquer tipo, o que pode causar erros em tempo de execução.
// List<int> evita isso porque só aceita inteiros.