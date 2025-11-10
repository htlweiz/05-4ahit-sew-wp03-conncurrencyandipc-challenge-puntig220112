using System;
using System.Threading;

namespace A2_RaceConditionBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
        
        // Bankkonto mit Startwert 1000 EUR erstellen
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");
        
        Thread t1 = new Thread(() => PerformBankOperations(account));
        Thread t2 = new Thread(() => PerformBankOperations(account));
        Thread t3 = new Thread(() => PerformBankOperations(account));
        Thread t4 = new Thread(() => PerformBankOperations(account));
        Thread t5 = new Thread(() => PerformBankOperations(account));
        Thread t6 = new Thread(() => PerformBankOperations(account));
        Thread t7 = new Thread(() => PerformBankOperations(account));
        Thread t8 = new Thread(() => PerformBankOperations(account));
        Thread t9 = new Thread(() => PerformBankOperations(account));
        Thread t10 = new Thread(() => PerformBankOperations(account));
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();
        t6.Start();
        t7.Start();
        t8.Start();
        t9.Start();
        t10.Start();
        t1.Join();
        t2.Join();
        t3.Join();
        t4.Join();
        t5.Join();
        t6.Join();
        t7.Join();
        t8.Join();
        t9.Join();
        t10.Join();
    }
    
    private static void PerformBankOperations(BankAccount account)
    {
        account.Deposit(100);
        Thread.Sleep(50);
        account.Withdraw(150);
        acount.GetBalance();
    }
}

