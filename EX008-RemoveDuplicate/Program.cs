/* Exercício 8 — Removendo Duplicatas
Dada a lista:

List<string> nomes = new List<string>
{ "Ana", "Carlos", "Ana", "Beatriz", "Carlos", "Diana", "Ana" };

Crie uma nova lista que contenha apenas os nomes sem repetição. Não use Distinct()
 — faça a lógica manualmente com Contains()*/
 
List<string> nomes = new List<string>
    { "Ana", "Carlos", "Ana", "Beatriz", "Carlos", "Diana", "Ana" };

List<string> semRepeticao = new List<string>();

foreach (var nome in nomes)
{
    if (!semRepeticao.Contains(nome))
    {
        semRepeticao.Add(nome);
    }
}