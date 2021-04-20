using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Handler1
    {
        public delegate void Handl1(string h1);
        public event Handl1 H1;

         public void Hand1(int a)
        {
            H1?.Invoke($"«Пора действовать, ведь уже {a}");
        }
       
    }
}
