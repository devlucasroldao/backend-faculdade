/* using System.Collections;

Pessoa pessoa1 = new Pessoa();

/* int qualIdade = pessoa1.GetIdade();
pessoa1.Idade = 22;
pessoa1.SetIdade(22);

Console.WriteLine($"Idade: {qualIdade}"); */

/* pessoa1.Idade = 25; // chama o set por de baixo dos panos

Console.WriteLine(pessoa1.Idade); // chama o get por de baixo dos panos 


// Array
// com 5 elementos, atribuiu valores por indice (começa em 0)
int[] notas = new int[5];

notas[0] = 10;
notas[1] = 5;
notas[2] = 8;
notas[3] = 9;
notas[4] = 1;

string[] frutas = new string["Maça", "Banana", "Uva"];

Console.WriteLine(frutas[0]);

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine(notas[i]);
} //percorrendo os itens

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
} //percorrendo os itens outra forma

//List<T>
List<string> livros = new List<string>();
// add item sem limites fixos (diferente da array)
livros.Add("Diario de um Banana");
livros.Add("Biblia Sagrada");
livros.Add("Culpa é das Estrelas");

//acessando por indice, igual a array
Console.WriteLine(livros[0]);

//Removendo pelo valor
livros.Remove("Diario de um Banana");
//removendo pelo indice
livros.RemoveAt(1);

//verificar 
bool tem = livros.Contains("Diario de um Banana"); //true (se tiver)
int posicao = livros.IndexOf("Diario de um Banana"); //em qual posição(index) está o item
int total = livros.Count; //total de livros(itens)

//inserindo em uma posição especifica
livros.Insert(0, "Naruto | Shippuden Vol.1");

foreach (string livro in livros)
{
    Console.WriteLine(livro);
} //percorrendo

List<int> numeros = new List<int> { '0', '1', '2', '3', '4', '5', '6', '7' };
numeros.Add(8); //setando na lista

//ArrayList
ArrayList mistura =  new ArrayList();
//aceita qualquer coisa...
mistura.Add(8);
mistura.Add("Lucas");
mistura.Add(-121232);
mistura.Add(34.54);
mistura.Add(true);

int numero = (int)mistura[0];
int erro = (int)mistura[1]; //dar erro */