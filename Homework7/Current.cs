using System;

namespace Homework7
{
    class Current
    {
        static void Main(string[] args)
        {
            int[] Array = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Число {i}");
                if (i == 77)
                {
                    Handler1 acount = new Handler1();
                    Handler2 acount2 = new Handler2();

                    acount.H1 += AccountStateMessage;
                    acount.Hand1(i);
                    acount.H1 -= AccountStateMessage;

                    acount2.H1 += AccountStateMessage2;
                   acount2.Hand1(i);

                    static void AccountStateMessage(string message)
                   {
                        Console.WriteLine(message);
                   }

                    static void AccountStateMessage2(string message)
                    {
                        Console.WriteLine(message);
                    }
                    //return;
                }
                
            }
        }
    }    
}
