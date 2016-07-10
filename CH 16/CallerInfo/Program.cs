using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
namespace CallerInfo
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] String file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] String member = "")
        {
            Console.WriteLine("{0}(Line:{1}) {2}: {3}", file, line, member, message);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐거운 프로그래밍!");
        }
    }
}
