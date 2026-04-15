// Criando array
int[] numeros = { 1, 2, 3, 4, 5 };

// Acessando
Console.WriteLine(numeros[0]);

// Percorrendo
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// foreach
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

//soma de arrays:
int soma = 0;
foreach (int n in numeros)
{
    soma += n;
}
Console.WriteLine(soma);

//maior número:
int maior = numeros[0];

foreach (int n in numeros)
{
    if (n > maior)
        maior = n;
}

//média:
int pares = 0;

foreach (int n in numeros)
{
    if (n % 2 == 0)
        pares++;
}