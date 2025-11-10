using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    static int countup = 1;
    static int countdown = 100;

    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        Thread threadA = new Thread(CountUpThreadA);
        Thread threadB = new Thread(CountDownThreadB);
        threadA.Start();
        threadB.Start();
        threadA.Join();
        threadB.Join();
        
    }
    
    private static void CountUpThreadA()
    {
        for (int i = 1; i <= 100; i++)
        {
            countup = i;
            if(countup == countdown){
                Console.WriteLine($"Thread A: {i}");
                Console.WriteLine($"Thread B: {countdown}");
                if(countup < countdown){
                    Console.WriteLine("Thread A wins!");
                } else if(countdown < countup){
                    Console.WriteLine("Thread B wins!");
                } else {
                    Console.WriteLine("It's a tie!");
                }
                return;
            }
            Console.WriteLine($"Thread A: {i}");
            Thread.Sleep(100); // Simuliere Arbeit

        }
    }
    
    private static void CountDownThreadB()
    {
       for (int i = 100; i >= 1; i--)
        {
            countdown = i;
            if(countup == countdown){
                Console.WriteLine($"Thread B: {i}");
                Console.WriteLine($"Thread A: {countup}");
                if(countup < countdown){
                    Console.WriteLine("Thread A wins!");
                } else if(countdown < countup){
                    Console.WriteLine("Thread B wins!");
                } else {
                    Console.WriteLine("It's a tie!");
                }
                return;
            }
            Console.WriteLine($"Thread B: {i}");
            Thread.Sleep(100); // Simuliere Arbeit
        }
    }
}
