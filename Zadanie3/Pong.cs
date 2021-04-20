using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
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
}

