/* Comparação e Conversão
Exercício 11 — Array → List → Array
Crie um array int[] numeros = { 1, 2, 3, 4, 5 };
Converta para List<int> usando new List<int>(numeros)
Adicione os números 6, 7 e 8 na lista
Converta de volta para array usando ToArray()
Exiba o array final
Objetivo: entender quando e como converter entre Array e List.*/

int[] numeros = { 1, 2, 3, 4, 5 };

List<int> lista = new List<int>(numeros);

lista.Add(6);
lista.Add(7);
lista.Add(8);

int[] novoArray = lista.ToArray();

foreach (int n in novoArray)
{
    Console.WriteLine(n);
}