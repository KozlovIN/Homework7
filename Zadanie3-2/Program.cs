using System;

namespace Zadanie3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Ping();
            var p2 = new Pong();

            for (int i = 1; i <= 100; i++)
            {
                p1.Pingvoid();
                p2.Pongvoid();

                Console.WriteLine("Игра окончена!");
                Console.ReadLine();
            }
        }
    }
}
