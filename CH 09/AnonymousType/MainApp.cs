using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "윤아", Age = "25" };
            Console.WriteLine("Name : {0}, Age : {1}", a.Name, a.Age);

            var b = new { subject = "수학", Scores = new int []{90,80,70,60} };
            Console.Write("Subject : {0}, Scores : ", b.subject);
            foreach (var score in b.Scores)
                Console.Write("{0} ", score);
            Console.WriteLine();
        }
    }
}
