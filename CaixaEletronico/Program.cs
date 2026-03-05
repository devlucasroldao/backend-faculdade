/* Simulador de Caixa Eletrônico

Tente resolver usando os conceitos que vimos.

    Requisitos:
    Comece com um saldo inicial (ex: `R$ 1000.00`).
    O menu (Ver Saldo, Depositar, Sacar, Sair) deve ser exibido repetidamente até que o usuário escolha "Sair" (Dica: `do-while` ou `while`).
    Use um `switch` para tratar a opção escolhida.
    Na opção "Sacar", use um `if` para verificar se há saldo suficiente.
    Na opção "Depositar", peça um valor e atualize o saldo.
    Mostre mensagens claras para cada operação. */

decimal saldo = 1000.0m;

Console.Write("Bem-Vindo ao caixa eletrônico da ADS\n");
int opcao = 0;

do
{
    Console.WriteLine("\n--MENU DO CAIXA ELETRÔNICO--\n1 - Ver Saldo\n2 - Depositar\n3 - Sacar\n4-Sair");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao) 
    {
        case 1: opcao = 1;
            Console.WriteLine($"Saldo Atual: {saldo:F2}");
            break;
        case 2: opcao = 2;
            Console.WriteLine($"Saldo Atual: {saldo}");
            Console.WriteLine("Qual valor deseja depositar?");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());
            saldo = saldo + deposito;
            Console.WriteLine($"Seu saldo agora é de R${saldo}");
            break;
        case 3: opcao = 3;
            Console.WriteLine($"Saldo Atual: {saldo}");
            Console.WriteLine("Qual valor deseja sacar?");
            decimal sacar = Convert.ToDecimal(Console.ReadLine());
            saldo = saldo - sacar;
            Console.WriteLine($"Saldo Atual: {saldo}");
            break;
        case 4: opcao = 4;
            Console.WriteLine($"Saldo Atual: {saldo}");
            Console.WriteLine("Obrigado por utilizar nossos serviços!\nSaindo do programa...");
            break;
    }
} while (opcao != 4);