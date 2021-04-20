using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new StringSearcher();
            numbers.H1 += SearchMessage;
            numbers.Search();
        }

        static void SearchMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}









//using System.Text.RegularExpressions.AspCodeRegex;
//using System.Text.RegularExpressions.AspEncodedExprRegex;
//using System.Text.RegularExpressions.AspExprRegex;
//using System.Text.RegularExpressions.CommentRegex;
//using System.Text.RegularExpressions.DatabindExprRegex;



//List<string> numbers = new List<string>();
//numbers.Add("One");
//numbers.Add("Two");
//numbers.Add("Three");
//numbers.Add("Four");
//numbers.Add("Five");

//Console.WriteLine("Hello World!");

//   

//List<string> authors = new List<string>();
//authors.Add("Mahesh Chand");
//authors.Add("Mahesh Chand");
//authors.Add("Mike Gold");
//authors.Add("Allen O'Neill");
//authors.Add("Marshal Troll");


//  Predicate<string> findPointPredicate = delegate (Point pt)

// string patter = @"Mahesh Chand";
// Создаем экземпляр Regex  
//  var s = new Regex(@"M");

// var authors = new List<string>() { "Mahesh Chand", "Mahesh Chand", "Mike Gold", "Allen O'Neill", "Marshal Troll" };
// Длинная строка  
//   string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
// Получаем все совпадения  
//    MatchCollection matchedAuthors = s.Matches(Convert.ToString(authors));
/// Выводим всех подходящих авторов  
//   for (int count = 0; count < matchedAuthors.Count; count++)
//    Console.WriteLine(matchedAuthors[count].Value);
//   H1?.Invoke($"«Пора действовать, ведь уже {s}");


//public void Hand1(int s)
//{

//}


//foreach (string river in matchedAuthors)
//{
//    Console.WriteLine(river);
//}