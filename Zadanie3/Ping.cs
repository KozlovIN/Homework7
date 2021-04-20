using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
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
}
