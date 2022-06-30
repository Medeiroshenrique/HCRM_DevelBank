using System;
using System.Globalization;
namespace DevelBanking {
    class Program {
        static void Main() {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=====================================================================");
                Console.WriteLine("                       Bem vindo ao HCRM_DevelBank!");
                Console.WriteLine("=====================================================================");
                Console.ResetColor();
                Console.WriteLine("Entre o numero da conta: ");
                Conta UserAcc = new Conta();
                UserAcc.NumAccount = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre o titular da conta: ");
                UserAcc.UserName = Console.ReadLine();

                Console.WriteLine("Crie uma Senha(digite-a): ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*sua senha deve ter pelo menos 8 digitos");
                Console.ResetColor();
                UserAcc.Password(Console.ReadLine());

                Console.WriteLine("Havera deposito inicial?(s/n)");
                char answer = char.Parse(Console.ReadLine());

                if (answer == 's')
                {
                    Console.WriteLine("Entre o valor de deposito inicial: ");
                    UserAcc.InitialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (answer == 'n')
                {
                    UserAcc.InitialDeposit = 0;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta " + UserAcc.NumAccount + ", Titular: " + UserAcc.UserName + ", " +
                    "Saldo: " + UserAcc.Balance);
                Console.ResetColor();

                Console.WriteLine();

                Console.WriteLine("Entre um valor para deposito: ");
                UserAcc.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + UserAcc.NumAccount + ", Titular: " + UserAcc.UserName + ", " +
                    "Saldo: " + UserAcc.Balance);
                Console.ResetColor();

                Console.WriteLine();

                Console.WriteLine("Entre um valor para saque:");
                UserAcc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + UserAcc.NumAccount + ", Titular: " + UserAcc.UserName + ", " +
                    "Saldo: " + UserAcc.Balance);
                Console.ResetColor();
                Console.WriteLine("*tarifa de 5 reais por saque*");

            
             
        }
    }
}