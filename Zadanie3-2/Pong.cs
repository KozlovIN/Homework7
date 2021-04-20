using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_2
{
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
}
