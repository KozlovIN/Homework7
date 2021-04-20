using System;

namespace ConsoleApp2
{

    public class Ping
    {

        public event Action Play = delegate { };
        public event Action GameOver = delegate { };

        public string Current { get; set; }
        public Ping()
        {
            
        }

        public string Pingvoid()
        {
            var p = new Pong();
            var rnd = new Random();
            int a = rnd.Next(0, 10);

            if (a > 2)
            {
                Play();
                Console.WriteLine($"Ping получил Pong ");
               
                return p.Pongvoid();
            }
            else
            {
                GameOver();
              Console.WriteLine($"Ping промахнулся! Победил Pong. ");
                return null;
            }
        }
    }

    public class Pong
    {

        public event Action Play = delegate { };
        public event Action GameOver = delegate { };

        public string Current { get; set; }
        public Pong()
        {
            
        }

        public string Pongvoid()
        {
            var p = new Ping();
            
            var rnd = new Random();
            int a = rnd.Next(0, 10);
           

            if (a > 2)
            {
                Play();
                
              Console.WriteLine($"Pong получил Ping ");

                return p.Pingvoid();
            }
            else
            {
                GameOver();
              Console.WriteLine($"Pong промахнулся! Победил Ping. ");
                return null;
                
            }

        }
    }
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
