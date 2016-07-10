﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
