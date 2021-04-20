using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[100];

            for (int i = 1; i <= 100; i++)
            {
                var p1 = new Ping();
                var p2 = new Pong();

                p1.Play += () => Console.WriteLine($"{p1.Current}");
                p1.GameOver += () => Console.WriteLine($"{p1.Current}");

                p2.Play += () => Console.WriteLine($"{p2.Current}");
                p2.GameOver += () => Console.WriteLine($"{p2.Current}");

                p1.Pingvoid();
                p2.Pongvoid();

                Console.WriteLine("Игра окончена!");
                Console.ReadLine();
            }
        }
    }
}
