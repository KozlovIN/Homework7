using System;

namespace ConsoleApp2
{
    
    class Ping
    {
        
        public string Pingvoid()
        {
        
            var rnd = new Random();
            int a = rnd.Next(0, 10);

            if (a > 2)
            {
                var p = new Pong();
              
                Console.WriteLine("Ping получил Pong ");
             
                return p.Pongvoid();
            }
            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong. ");
                return null;
            }
        }
    }

    public class Pong
    {
        public string Pongvoid()
        {
            var p = new Ping();
         
            var rnd = new Random();
            int a = rnd.Next(0, 10);
         
            if (a > 2)
            {
                Console.WriteLine("Pong получил Ping ");
                return p.Pingvoid();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping. ");
                return null;
            }

        }
    }
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
