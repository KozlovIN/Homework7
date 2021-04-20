using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zadanie2
{
    public class StringSearcher
    {
        public delegate void Handl1(string h1);
        public event Handl1 H1;

        public List<string> list = new () { "One", "Two", "Three", "Four", "Five" };

        
        public void Search()
        {
            string s = "One";

             for (int i = 0; i < list.Count; i++)
            {
                if (string.Equals(s, list[i]))
                {
                    H1?.Invoke($"{s}");
                }
            }
        }
    }
}
