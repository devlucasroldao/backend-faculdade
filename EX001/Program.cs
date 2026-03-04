/* Console.WriteLine("Hello, World!");
Console.WriteLine("Olá, Universo! Eu me chamo Lucas e sou um desenvolvedor .NET. 🚀"); */

/* int numero = 10;
double pi = 3.1415;
char letra = "U+0041";
char letraA = "A";
bool isTrue = false;
string mensagem = "Olá, Mundo!"; */

//Console.WriteLine($"{letra}  {letraA}");//

Console.WriteLine("Bem-vindo ao C#");

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos de idade!");

Console.WriteLine("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
Console.WriteLine($"A soma dos números {numero1} e {numero2} é: {soma}");

double sub_nums = numero1 - numero2;
Console.WriteLine($"A subtração dos números {numero1} e {numero2} é: {sub_nums}");

double mult_nums = numero1 * numero2;
Console.WriteLine($"A multiplicação dos números {numero1} e {numero2} é: {mult_nums}");

double dividir = numero1 / numero2;
Console.WriteLine($"A divisão dos números {numero1} e {numero2} é: {dividir}");

// atividade 1 e 2 eu fiz na mesma! 