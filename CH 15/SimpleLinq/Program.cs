using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile = {
                                       new Profile(){Name="서현", Height=168},
                                       new Profile(){Name="윤아",Height= 169},
                                       new Profile(){Name="유리",Height= 165},
                                       new Profile(){Name="태연",Height= 160},
                                       new Profile(){Name="써니",Height= 155}
                                   };
            var profiles = from profile in arrProfile
                           where profile.Height < 165
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };
            foreach (var profile in profiles)
            {
                Console.WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
            }
        }
    }
}
