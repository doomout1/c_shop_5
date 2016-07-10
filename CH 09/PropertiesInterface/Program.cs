using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInterface
{
    interface INameValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NameValue : INameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue() { Name = "이름", Value = "서현" };
            NameValue height = new NameValue() { Name = "키", Value = "166Cm" };
            NameValue weight = new NameValue() { Name = "몸무게", Value = "51Kg" };

            Console.WriteLine("{0} : {1}", name.Name, name.Value);
            Console.WriteLine("{0} : {1}", height.Name, height.Value);
            Console.WriteLine("{0} : {1}", weight.Name, weight.Value);
        }
    }
}
