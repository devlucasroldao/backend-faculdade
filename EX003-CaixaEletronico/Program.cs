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
        case 1:
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
            break;

        case 2:
            Console.WriteLine("Qual valor deseja depositar?");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());

            saldo += deposito;

            Console.WriteLine($"Depósito realizado. Saldo atual: R$ {saldo:F2}");
            break;

        case 3:
            Console.WriteLine("Qual valor deseja sacar?");
            decimal saque = Convert.ToDecimal(Console.ReadLine());

            if (saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine($"Saque realizado. Saldo atual: R$ {saldo:F2}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

            break;

        case 4:
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 4);