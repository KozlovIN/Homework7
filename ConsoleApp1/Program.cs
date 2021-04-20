using System;

namespace ConsoleApp1
{

    public class Pub
    {
        //Свойство OnChange содержит список всех callback-методов подписчиков 
        public event Action OnChange1 = delegate { };

        public void Raise()
        {
            var p2 = new Pub2();
            //Вызов OnChange
            OnChange1();
            p2.Raise2();
          
        }
    }

    public class Pub2
    {
        //Свойство OnChange содержит список всех callback-методов подписчиков 
        public event Action OnChange2 = delegate { };

        public void Raise2()
        {
            var p1 = new Pub();
            //Вызов OnChange
            OnChange2();
            p1.Raise();
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                //Инициализируем объект класса pub
                var p1 = new Pub();
                var p2 = new Pub2();

                //подписываем вывод Subscriber 1 на событие OnChange 
                p1.OnChange1 += () => Console.WriteLine("Ping!");
                //подписываем вывод Subscriber 2 на событие OnChange
                p2.OnChange2 += () => Console.WriteLine("Subscriber 2!");

                //генерируем событие
                p1.Raise();
                p2.Raise2();
              

                //После вызова метода Raise() все подписанные callback-методы та же будут вызваны

                Console.WriteLine("Press enter to terminate!");
                Console.ReadLine();
            }
        }
    }
}
