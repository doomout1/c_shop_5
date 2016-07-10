using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
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
            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 160 into g
                              select new { GroupKey = g.Key, Profiles = g };
            foreach (var Group in listProfile)
            {
                Console.WriteLine("- 160cm 미만? : {0}", Group.GroupKey);
                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine("      {0}, {1}", profile.Name, profile.Height);
                }
            }
        }
    }
}
