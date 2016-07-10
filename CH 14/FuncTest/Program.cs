﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10; //입력매개변수는 없으며, 무조건 10을 반환
            Console.WriteLine("func1() : {0}", func1());

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine("func2(4) : {0}", func2(4));

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine("func3(22/7) : {0}", func3(22,7));
        }
    }
}
