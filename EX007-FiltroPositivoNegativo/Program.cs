/* Exercício 7 — Filtrando Valores
Crie uma List<int> com 10 números variados (positivos e negativos). Em seguida, crie duas novas listas:
uma apenas com os positivos e outra apenas com os negativos. */

List<int> numeros = new List<int> { -5, 10, -3, 7, 0, -1, 8, -2, 4, -6 };

List<int> positivos = new List<int>();
List<int> negativos = new List<int>();

foreach (int num in numeros)
{
    if (num >= 0)
        positivos.Add(num);
    else
        negativos.Add(num);
}