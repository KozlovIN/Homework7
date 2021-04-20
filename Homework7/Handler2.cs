using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Handler2
    {
        public delegate void Handl2(string h1);
        public event Handl2 H1;

        public void Hand1(int a)
        {
            H1?.Invoke($"«Уже {a}, давно пора было начать!");
        }

    }
}
