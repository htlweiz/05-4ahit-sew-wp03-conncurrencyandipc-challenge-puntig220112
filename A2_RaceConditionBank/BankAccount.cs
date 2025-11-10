using System;
using System.Threading;

namespace A2_RaceConditionBank;
public class BankAccount
{
    private int balance;
    private readonly object _lockObject = new object();
   
    
    public BankAccount(int initial) 
    { 
        balance = initial; 
    }
    
    public void Deposit(int amount) 
    { 
       lock (_lockObject){
            balance += amount;
       }
       
    }
    
    public void Withdraw(int amount) 
    { 
        lock (_lockObject){
            balance -= amount;
        }
    }
    
    public int GetBalance() 
    {
        return balance;
    }
}
