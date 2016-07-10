﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    class Program
    {
        class InvalidArgumentException : Exception
        {
            public InvalidArgumentException()
            {
            }
            public InvalidArgumentException(string message) : base(message)
            {
            }
            public object Argument
            {
                get;
                set;
            }
            public object Range
            {
                get;
                set;
            }
        }
      
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach (uint arg in args)
            {
                if (arg > 255)
                {
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
                }
            }
            return (alpha << 24 &0xff000000) | (red << 16 & 0x00ff00000) | (green << 8 & 0x0000ff00) | (blue & 0x000000FF);
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111,111,111));
                Console.WriteLine("0x{0:X}", MergeARGB(1,65,192,128));
                Console.WriteLine("0x{0:X}", MergeARGB(0,255,255,300));
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Argument : {0}, Range:{1}", e.Argument, e.Range);
            }
        }
    }
}
