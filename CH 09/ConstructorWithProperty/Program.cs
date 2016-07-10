using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithProperty
{
    class Program
    {
        class BirthdayInfo
        {
            public string Name
            {
                get;
                set;
            }

            public DateTime Birthday
            {
                get;
                set;
            }

            public int Age
            {
                get
                {
                    return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
                }
            }
        }
        static void Main(string[] args)
        {
            //기존방식
            /*
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28); 
             */
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
