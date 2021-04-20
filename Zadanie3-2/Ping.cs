using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_2
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
}
