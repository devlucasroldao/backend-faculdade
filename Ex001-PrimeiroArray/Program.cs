/* Exercício 1 — Criando seu primeiro Array
Crie um array de int com 5 notas de alunos (valores à sua escolha). Em seguida, percorra o array com um for e exiba cada nota no console.

Saída esperada:

Nota 1: 8
Nota 2: 7
Nota 3: 9
Nota 4: 10
Nota 5: 6 */

int[] notas = new int[6];
notas[0] = 8;
notas[1] = 7;
notas[2] = 9;
notas[3] = 10;
notas[4] = 6;

Console.WriteLine($"Nota 1: {notas[0]}");
Console.WriteLine($"Nota 2: {notas[1]}");
Console.WriteLine($"Nota 3: {notas[2]}");
Console.WriteLine($"Nota 4: {notas[3]}");
Console.WriteLine($"Nota 5: {notas[4]}");