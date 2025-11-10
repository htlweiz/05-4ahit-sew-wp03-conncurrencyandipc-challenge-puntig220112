using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace A3_ProducerConsumerQueue;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");

       // TODO
        var Queue = new ConcurrentQueue<int>();
        List<Producer> producers = new List<Producer>();
        for (int i = 1; i <= 5; i++)
        {
            producers.Add(new Producer(i, Queue));
        }
        Consumer consumer = new Consumer(Queue);
       
        

        Console.WriteLine("Producer und Consumer gestartet...\n");

        while (true)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Aktueller Queue-Füllstand: {Queue.Count}");
            if (Queue.Count > 50)
            {
                Console.WriteLine("Queue-Füllstand hat 50 überschritten. Beende alle Producer und Consumer...");
                foreach (Producer p in producers)
                {
                    p.Stop();
                }
                break;
            }
        }
        // Überwachung: Jede Sekunde Queue-Füllstand ausgeben und auf >50 prüfen
        
        
        // TODO


        // Alle Producer stoppen
       

        // Consumer stoppen
       
       
    }
}
