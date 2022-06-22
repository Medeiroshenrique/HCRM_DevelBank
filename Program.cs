using System;
using System.Globalization;
namespace DevelBanking {
    class Program {
        static void Main() {
            Console.WriteLine("Entre o numero da conta: ");
            Conta UserAcc = new Conta();
            UserAcc.NumAccount=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre o titular da conta: ");
            UserAcc.UserName=Console.ReadLine();
            
            Console.WriteLine("Havera deposito inicial?(s/n)");
            char answer = char.Parse(Console.ReadLine());
            
            if(answer == 's')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                UserAcc.InitialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }else if(answer=='n'){
                UserAcc.InitialDeposit = 0;}
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta "+UserAcc.NumAccount +", Titular: "+ UserAcc.UserName + ", " +
                "Saldo: "+UserAcc.Balance);
            
            Console.WriteLine();
            
            Console.WriteLine("Entre um valor para deposito: ");
            UserAcc.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine("Conta " + UserAcc.NumAccount + ", Titular: " + UserAcc.UserName + ", " +
                "Saldo: " + UserAcc.Balance);
            
            Console.WriteLine();

            Console.WriteLine("Entre um valor para saque:");
            UserAcc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine("Conta " + UserAcc.NumAccount + ", Titular: " + UserAcc.UserName + ", " +
                "Saldo: " + UserAcc.Balance);
        }
    }
}