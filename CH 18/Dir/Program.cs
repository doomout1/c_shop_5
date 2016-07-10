using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            else
                directory = args[0];

            Console.WriteLine("{0} directory Info", directory);
            Console.WriteLine("- Directories : ");
            var directories = (from dir in Directory.GetDirectories(directory)
                         let info = new DirectoryInfo(dir)
                         select new
                         {
                             Name = info.Name,
                             Attributes = info.Attributes
                         }).ToList();

            foreach(var d in directories)
                Console.WriteLine("{0} : {1}", d.Name, d.Attributes);
            
            Console.WriteLine("-Files : ");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         }).ToList();

            foreach (var f in files)
                Console.WriteLine("{0} : {1}, {2}", f.Name,f.FileSize, f.Attributes);
         }
    }
}
