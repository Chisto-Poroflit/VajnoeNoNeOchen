using System.Collections.Generic;
using DbLibrary;
using System.Linq;

namespace SichCreateDB
{
    public static class DBToExcel
    {
        public static List<int> GroupCounter()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<int> groupsInCourses = new List<int>();
                var couples = db.Groups.ToList();
                int count = db.Groups.Max(p => p.SemesterNumber);
                if (count % 2 == 1)
                    count = (count + 1) / 2;
                else
                    count /= 2;
                for (int i = 1; i <= count; i++)
                {
                    int counter;
                    var asd = (from gr in db.Groups
                               where gr.SemesterNumber == i * 2
                               select gr.GroupNumber).Distinct();
                    var dsa = (from gr in db.Groups
                               where gr.SemesterNumber == i * 2 - 1
                               select gr.GroupNumber).Distinct();
                    if (asd == null && dsa == null)
                        counter = 0;
                    else
                        counter = asd.Count() + dsa.Count();
                    //int groupsCount = db.Groups.Count(p => p.SemesterNumber == i * 2);
                    //int groupsCountChet = db.Groups.Count(p => p.SemesterNumber == i * 2 - 1);
                    groupsInCourses.Add(counter);
                }
                return groupsInCourses;
            }
        }


    }
}
